using Baidu.Aip.Face;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDemo
{
    public partial class Form1 : Form
    {

        private readonly string API_KEY = "I9ahRDhftvHEj2XkTLET5Ewi";

        private readonly string SECRET_KEY = "PoKM8tMas3kjWZ98uBTTVDNjExcerhoX";

        private Face client = null;

        public Form1()
        {
            InitializeComponent();
            client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
        }


        private void btnLoadPic1_Click(object sender, EventArgs e)
        {
            //选择图片
            picPath1 = String.Empty;
            OpenFileDialog fileDia = new OpenFileDialog();
            fileDia.CheckFileExists = true;
            fileDia.Filter = "图片(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            
            if(fileDia.ShowDialog() == DialogResult.OK)
            {
                picPath1 = fileDia.FileName;
            }
            else
            {
                return;
            }
            pictureBox1.Load(picPath1);

            //人脸检测
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("face_field", "age,beauty,expression,face_shape,gender,glassed,emotion,race,face_type");
            JObject jObject = client.Detect(ImgToBase64(picPath1), "BASE64", options);

            //解析结果
            textBoxDetection1.Text = parseDetectResult(jObject, pictureBox1);
        }

        private void btnLoadPic2_Click(object sender, EventArgs e)
        {
            //选择图片
            picPath2 = String.Empty;
            OpenFileDialog fileDia = new OpenFileDialog();
            fileDia.CheckFileExists = true;
            fileDia.Filter = "图片(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (fileDia.ShowDialog() == DialogResult.OK)
            {
                picPath2 = fileDia.FileName;
            }
            else
            {
                return;
            }
            pictureBox2.Load(picPath2);

            //人脸检测
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("face_field", "age,beauty,expression,face_shape,gender,glassed,emotion,race,face_type");
            JObject jObject = client.Detect(ImgToBase64(picPath2), "BASE64", options);

            //解析结果
            textBoxDetection2.Text = parseDetectResult(jObject, pictureBox2);
        }



        /**
         * 解析人脸检测结果
         */
        private string parseDetectResult(JObject jObject, PictureBox pictureBox) {
            Dictionary<string, string> expressionDict = new Dictionary<string, string> { { "none", "不笑" }, { "smile", "微笑" }, { "laugh", "大笑" } };
            Dictionary<string, string> faceShapeDict = new Dictionary<string, string> { { "square", "正方形" }, { "triangle", "三教形" }, { "oval", "椭圆" }, { "heart", "瓜子脸" }, { "round", "圆形" } };
            Dictionary<string, string> genderDict = new Dictionary<string, string> { { "male", "男性" }, { "female", "女性" } };
            Dictionary<string, string> glassesDict = new Dictionary<string, string> { { "none", "无眼镜" }, { "common", "普通眼镜" }, { "sun", "太阳镜"} };
            Dictionary<string, string> emotionDict = new Dictionary<string, string> { { "angry", "愤怒" }, { "disgust", "厌恶" }, { "fear", "恐惧" }, 
                                                                                    { "happy", "高兴" }, { "sad", "伤心" }, { "surprise", "惊讶" },
                                                                                    { "neutral", "无表情" }, { "pouty", "噘嘴" }, { "grimace", "鬼脸" }};
            Dictionary<string, string> raceDict = new Dictionary<string, string> { { "yellow", "黄种人" }, { "white", "白种人" }, { "black", "黑种人" }, { "arabs", "阿拉伯人" } };
            Dictionary<string, string> faceTypeDict = new Dictionary<string, string> { { "human", "真实人脸" }, { "cartoon", "卡通人脸" }};


            int errorCode = int.Parse(jObject.GetValue("error_code").ToString());
            string text = String.Empty;
            if (errorCode == 0)
            {
                JToken result = jObject.GetValue("result");
                JArray faceList = result.Value<JArray>("face_list");
                JToken faceItem = faceList.Children().First();
                //标记人脸位置
                JToken location = faceItem.Value<JToken>("location");
                int left = location.Value<int>("left");
                int top = location.Value<int>("top");
                int width = location.Value<int>("width");
                int height = location.Value<int>("height");
                float rotation = location.Value<float>("rotation");
                Graphics graphics = Graphics.FromImage(pictureBox.Image);
                graphics.TranslateTransform(left, top);
                graphics.RotateTransform(rotation);
                graphics.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(0, 0, width, height));
                graphics.ResetTransform();
                graphics.Save();

                //显示检测结果
                int age = faceItem.Value<int>("age");
                double beauty = faceItem.Value<double>("beauty");
                JToken expression = faceItem.Value<JToken>("expression");
                JToken faceShape = faceItem.Value<JToken>("face_shape");
                JToken gender = faceItem.Value<JToken>("gender");
                JToken glasses = faceItem.Value<JToken>("glasses");
                JToken emotion = faceItem.Value<JToken>("emotion");
                JToken race = faceItem.Value<JToken>("race");
                JToken faceType = faceItem.Value<JToken>("face_type");

                text += "年龄：" + age + "\r\n";
                text += "颜值：" + beauty + "\r\n";
                if (expression != null && !expression.Value<String>("type").Equals(String.Empty))
                {
                    text += "表情：" + expressionDict[expression.Value<String>("type")] +"  置信度："+expression.Value<double>("probability") + "\r\n";
                }
                if (faceShape != null && !faceShape.Value<String>("type").Equals(String.Empty))
                {
                    text += "脸型：" + faceShapeDict[faceShape.Value<String>("type")] + "  置信度：" + faceShape.Value<double>("probability") + "\r\n";
                }
                if (gender != null && !gender.Value<String>("type").Equals(String.Empty))
                {
                    text += "性别：" + genderDict[gender.Value<String>("type")] + "  置信度：" + gender.Value<double>("probability") + "\r\n";
                }
                if (glasses != null && !glasses.Value<String>("type").Equals(String.Empty))
                {
                    text += "眼镜：" + glassesDict[glasses.Value<String>("type")] + "  置信度：" + glasses.Value<double>("probability") + "\r\n";
                }
                if (emotion!=null && !emotion.Value<String>("type").Equals(String.Empty))
                {
                    text += "情绪：" + emotionDict[emotion.Value<String>("type")] + "  置信度：" + emotion.Value<double>("probability") + "\r\n";
                }
                if (race != null && !race.Value<String>("type").Equals(String.Empty))
                {
                    text += "人种：" + raceDict[race.Value<String>("type")] + "  置信度：" + race.Value<double>("probability") + "\r\n";
                }
                if (faceType != null && !faceType.Value<String>("type").Equals(String.Empty))
                {
                    text += "类别：" + faceTypeDict[faceType.Value<String>("type")] + "  置信度：" + faceType.Value<double>("probability");
                }
            }
            else
            {
                text = jObject.GetValue("error_msg").ToString();
            }
            return text;
        }

        /**
         * 图片转base64
         */
        private string ImgToBase64(string path)
        {
            try
            {
                return Convert.ToBase64String(File.ReadAllBytes(path));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string picPath1 = String.Empty;
        private string picPath2 = String.Empty;
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(picPath1.Equals(String.Empty) || picPath2.Equals(String.Empty))
            {
                MessageBox.Show("请载入两幅图片！");
                return;
            }           
            var faces = new JArray
                {
                    new JObject
                    {
                        {"image", ImgToBase64(picPath1)},
                        {"image_type", "BASE64"},
                        {"quality_control", "LOW"},
                    },
                    new JObject
                    {
                        {"image", ImgToBase64(picPath2)},
                        {"image_type", "BASE64"},
                        {"quality_control", "LOW"},
                    }
                };
            JObject jObject = client.Match(faces);
            int errorCode = int.Parse(jObject.GetValue("error_code").ToString());
            string text = String.Empty;
            if (errorCode == 0)
            {
                JToken result = jObject.GetValue("result");
                float score = result.Value<float>("score");
                if (score >= 80)
                {
                    text += "同一个人\r\n";
                }
                else
                {
                    text += "不是同一个人\r\n";
                }
                text += "相似度：" + score;
            }
            else
            {
                text = jObject.GetValue("error_msg").ToString();
            }
            textBoxCompare.Text = text;
        }
    }
}
