using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_chat
{
    [ServiceContract (CallbackContract =typeof(IServiceChatCallBack))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);
        [OperationContract]
        void Disconnect(int ID);
        [OperationContract(IsOneWay =true)]
        void SendMsg(string msg,int id);
    }
    interface IServiceChatCallBack
    {
        [OperationContract(IsOneWay =true)]
        void MsgCallBack(string msg);
    }
}
