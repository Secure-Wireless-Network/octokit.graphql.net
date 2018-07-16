namespace Octokit.GraphQL.Core.UnitTests.Models
{
    using System;
    using System.Linq.Expressions;
    using Core;

    public class Label : QueryableValue<Label>
    {
        public Label(Expression expression) : base(expression)
        {
        }

        public string Color { get; }
        public DateTimeOffset? CreatedAt { get; }
        public string Description { get; }
        public ID Id { get; }
        public bool IsDefault { get; }
        public string Name { get; }
        public string ResourcePath { get; }
        public DateTimeOffset? UpdatedAt { get; }
        public string Url { get; }

        internal static Label Create(Expression expression)
        {
            return new Label(expression);
        }
    }
}