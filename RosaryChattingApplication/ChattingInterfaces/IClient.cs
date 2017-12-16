﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerInterfaces
{   

    public interface IClient
    {
        [OperationContract]
        void GetMessage(string message, string userName);

        [OperationContract]
        void GetUpdate(int value, string userName);

        #region Bead
        
        [OperationContract]
        void GetBeadMessage(string message, string userName);

        [OperationContract]
        void GetBeadNumberMessage(int message, string userName);

        [OperationContract]
        void GetBeadListMessage(List<string> listofbeadpeople, string userName);

        #endregion Bead
    }
}
