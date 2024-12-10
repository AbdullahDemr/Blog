using Microsoft.Extensions.Options;
using System;

namespace TigrisTech.Shared.Utilities.Helpers.Abstract
{
    public interface IWritableOptions<out T> : IOptionsSnapshot<T> where T : class, new()
    {
        void Update(Action<T> applyChanges);//(x=>x.Header ="Yeni Başlık")
        //(x=>{ x.Header="dfsdfd",x.Content = "asdfasdfsfs")
    }
}
