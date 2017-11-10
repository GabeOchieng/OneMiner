﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace OneMiner.Model.Config
{
    class Config
    {
        public JsonValues Data{get;set;}
        private ConfigFileManager m_config_manager = new ConfigFileManager();
        public Config()
        {
            try
            {
                Data = (JsonValues)new JavaScriptSerializer().Deserialize(m_config_manager.Data, typeof(JsonValues));

            }
            catch (FormatException ex)
            {

            }
        }
        public void Save()
        {
            try
            {
                string data=new JavaScriptSerializer().Serialize(Data);
                m_config_manager.Data = data;
                m_config_manager.WriteData();

            }
            catch (FormatException ex)
            {

            }
        }

    }
}