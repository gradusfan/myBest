using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFF_Vision

{
    [Serializable]
    public class Product
    {
        /// <summary>
        /// 项目实例
        /// </summary>
        private static Product _instance;
        /// <summary>
        /// 项目实例
        /// </summary>
        public static Product Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Product();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }


        public readonly string VisionPath = @"D:\VisionConfig\配置文件\";

        public string CurrentModel = string.Empty;

        /// <summary>
        /// A区模板位X
        /// </summary>
        public string A_model_X = string.Empty;
        /// <summary>
        /// A区模板位Y
        /// </summary>
        public string A_model_Y = string.Empty;
        /// <summary>
        /// B区模板位X
        /// </summary>
        public string B_model_X = string.Empty;
        /// <summary>
        /// B区模板位Y
        /// </summary>
        public string B_model_Y = string.Empty;






        /// <summary>
        /// 服务器IP
        /// </summary>
        public string Sever_IP = string.Empty;
        /// <summary>
        /// 机械手IP
        /// </summary>
        public string Robot_IP = string.Empty;
        /// <summary>
        /// 机械手端口
        /// </summary>
        public string Robot_Prot = string.Empty;
        /// <summary>
        /// 旋转中心X
        /// </summary>
        public string RotationCenter_X = string.Empty;
        /// <summary>
        /// 旋转中心Y
        /// </summary>
        public string RotationCenter_Y = string.Empty;
        /// <summary>
        /// 图片保存路径
        /// </summary>
        public string SaveImgPath = string.Empty;

        /// <summary>
        /// 模板机械手X
        /// </summary>
        public List<string> Robot_X = new List<string>();
        /// <summary>
        /// 模板机械手Y
        /// </summary>
        public List<string> Robot_Y = new List<string>();



        /// <summary>
        /// 九点标定-像素X
        /// </summary>
        public List<string> Pixel_X = new List<string>();
        /// <summary>
        /// 九点标定-像素Y
        /// </summary>
        public List<string> Pixel_Y = new List<string>();

        private List<ModelConfig> models = new List<ModelConfig>();
        /// <summary>
        /// 产品信息
        /// </summary>
        public List<ModelConfig> Models { get => models; set => models = value; }

        /// <summary>
        /// 获取产品信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ModelConfig GetModelbyName(string name)
        {
            ModelConfig modelConfig = null;
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].ModelName == name)
                {
                    modelConfig = models[i];
                    break;
                }
            }

            return modelConfig;
        }

        public int GetModeIndexlbyName(string name)
        {
            int index = -1;
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].ModelName == name)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

    }
    [Serializable]
    public class ModelConfig
    {
        private string modelName = string.Empty;
        private string template_X = string.Empty;
        private string template_Y = string.Empty;
        private string template_U = string.Empty;
        private string rbt_TemplateX = string.Empty;
        private string rbt_TemplateY = string.Empty;
        private string rbt_TemplateU = string.Empty;

        private string Btemplate_X = string.Empty;
        private string Btemplate_Y = string.Empty;
        private string Btemplate_U = string.Empty;
        private string Brbt_TemplateX = string.Empty;
        private string Brbt_TemplateY = string.Empty;
        private string Brbt_TemplateU = string.Empty;

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ModelName { get => modelName; set => modelName = value; }
        /// <summary>
        /// 模板坐标X
        /// </summary>
        public string Template_X { get => template_X; set => template_X = value; }
        /// <summary>
        /// 模板坐标Y
        /// </summary>
        public string Template_Y { get => template_Y; set => template_Y = value; }
        /// <summary>
        /// 机械模板坐标X
        /// </summary>
        public string Rbt_TemplateX { get => rbt_TemplateX; set => rbt_TemplateX = value; }
        /// <summary>
        ///  机械模板坐标Y
        /// </summary>
        public string Rbt_TemplateY { get => rbt_TemplateY; set => rbt_TemplateY = value; }
        /// <summary>
        /// 模板坐标U
        /// </summary>
        public string Template_U { get => template_U; set => template_U = value; }
        /// <summary>
        ///  机械模板坐标U
        /// </summary>
        public string Rbt_TemplateU { get => rbt_TemplateU; set => rbt_TemplateU = value; }

        /// <summary>
        /// B区模板坐标X
        /// </summary>
        public string BTemplate_X { get => Btemplate_X; set => Btemplate_X = value; }
        /// <summary>
        /// B区模板坐标Y
        /// </summary>
        public string BTemplate_Y { get => Btemplate_Y; set => Btemplate_Y = value; }
        /// <summary>
        /// B区机械模板坐标X
        /// </summary>
        public string BRbt_TemplateX { get => Brbt_TemplateX; set => Brbt_TemplateX = value; }
        /// <summary>
        ///  B区机械模板坐标Y
        /// </summary>
        public string BRbt_TemplateY { get => Brbt_TemplateY; set => Brbt_TemplateY = value; }
        /// <summary>
        /// B区模板坐标U
        /// </summary>
        public string BTemplate_U { get => Btemplate_U; set => Btemplate_U = value; }
        /// <summary>
        ///  B区机械模板坐标U
        /// </summary>
        public string BRbt_TemplateU { get => Brbt_TemplateU; set => Brbt_TemplateU = value; }
    }
}
