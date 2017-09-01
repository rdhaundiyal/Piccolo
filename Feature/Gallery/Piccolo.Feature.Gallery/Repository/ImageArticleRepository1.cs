using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Feature.Gallery.Models.Search;
using System.Linq;
using System.Linq.Expressions;

namespace Piccolo.Feature.Gallery.Repository
{
    public class ImageArticleRepository1 : BaseRepository<ImageArticle, ImageArticleSearchItem>
    {


        public override Expression<Func<ImageArticleSearchItem, bool>> GetCondition(Dictionary<string, object> parameters)
        {
            ParameterExpression param = Expression.Parameter(typeof(ImageArticleSearchItem), "t");
           Expression finalExpression = Expression.Constant(true);
           
                 MemberExpression member = Expression.Property(param, "Services");
        ConstantExpression constant = Expression.Constant(parameters["Services"]);
            //  var  exp=Expression.Equal(member, constant);

       var exp=   Expression.Call(member, ContainsMethod, constant);
            
            finalExpression=Expression.AndAlso(finalExpression,exp);
            return Expression.Lambda<Func<ImageArticleSearchItem,bool>>(finalExpression,param);
                
        
           // return k=>k.Image!=null;
        }

   

    }
}