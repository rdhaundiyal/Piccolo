using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Feature.Gallery.Models.Search;
using System.Linq;
using System.Linq.Expressions;
using Piccolo.Foundation.Repository.Base;

namespace Piccolo.Feature.Gallery.Repository
{
    public class ImageArticleRepository : BaseRepository<ImageArticle, ImageArticleSearchItem>
    {


        public override Expression<Func<ImageArticleSearchItem, bool>> GetCondition(Dictionary<string, object> parameters)
        {
            ParameterExpression param = Expression.Parameter(typeof(ImageArticleSearchItem), "k");
           Expression finalExpression = Expression.Constant(true);
           
                 MemberExpression member = Expression.Property(param, "Services");
        ConstantExpression constant = Expression.Constant(parameters["Services"]);
          
       var exp=   Expression.Call(member, ContainsMethod, constant);
            
            finalExpression=Expression.AndAlso(finalExpression,exp);
            return Expression.Lambda<Func<ImageArticleSearchItem,bool>>(finalExpression,param);
            
        }

   

    }
}
