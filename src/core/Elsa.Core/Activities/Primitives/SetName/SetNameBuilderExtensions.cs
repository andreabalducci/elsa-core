using System;
using System.Threading.Tasks;
using Elsa.Builders;
using Elsa.Services.Models;

// ReSharper disable once CheckNamespace
namespace Elsa.Activities.Primitives
{
    public static class SetNameBuilderExtensions
    {
        public static IActivityBuilder SetName(this IBuilder builder, Action<ISetupActivity<SetName>> setup) => builder.Then(setup);
        public static IActivityBuilder SetName(this IBuilder builder, Func<ActivityExecutionContext, ValueTask<string?>> value) => builder.SetName(activity => activity.WithValue(value));
        public static IActivityBuilder SetName(this IBuilder builder, Func<ActivityExecutionContext, string?> value) => builder.SetName(activity => activity.WithValue(value));
        public static IActivityBuilder SetName(this IBuilder builder, Func<ValueTask<string?>> value) => builder.SetName(activity => activity.WithValue(value));
        public static IActivityBuilder SetName(this IBuilder builder, Func<string?> value) => builder.SetName(activity => activity.WithValue(value));
        public static IActivityBuilder SetName(this IBuilder builder, string? value) => builder.SetName(activity => activity.WithValue(value));
    }
}