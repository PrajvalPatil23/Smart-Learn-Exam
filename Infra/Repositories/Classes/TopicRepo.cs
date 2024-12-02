using Core;
using Infra.Repositories.Interfaces;
using Infra.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class TopicRepo : GenericRepo<Topic>, ITopicRepo
    {
        Context cc;

        public TopicRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<TopicVM> GetTopicsBySubject(long subjectId)
        {
            var result = cc.Topics
                 .Where(t => t.SubjectID == subjectId)
                 .Select(t => new TopicVM
                 {
                     TopicID = t.TopicID,
                     TopicName = t.TopicName
                 }).ToList();

            return result;
        }
    }
    }


