﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImpl.svc or RestServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImpl : IRestServiceImpl
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string XMLData(string id)
        {
            return "Your requested product " + id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string JSONData(string id)
        {
            return "Your requested product " + id;
        }
    }
}
