namespace Octokit.GraphQL.Core.UnitTests.Models
{
    using System.Linq.Expressions;
    using Core;
    using Builders;

    public class LabelConnection : QueryableValue<LabelConnection>, IPagingConnection<Label>
    {
        public LabelConnection(Expression expression) : base(expression)
        {
        }

        public IQueryableList<Label> Nodes => this.CreateProperty(x => x.Nodes);

        public PageInfo PageInfo => this.CreateProperty(x => x.PageInfo, PageInfo.Create);

        IPageInfo IPagingConnection.PageInfo => PageInfo;

        internal static LabelConnection Create(Expression expression)
        {
            return new LabelConnection(expression);
        }
    }
}