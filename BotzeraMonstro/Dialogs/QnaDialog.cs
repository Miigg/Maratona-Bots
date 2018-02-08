using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BotzeraMonstro.Dialogs
{
    [Serializable]
    public class QnaDialog :QnAMakerDialog
    {
        public QnaDialog():base(new QnAMakerService(new QnAMakerAttribute(ConfigurationManager.AppSettings["QnaSubscriptionKey"], ConfigurationManager.AppSettings["QnaKnowledgebaseId"], "Nao entendi desculpe", 0.5)))
        {

        }

    }
}