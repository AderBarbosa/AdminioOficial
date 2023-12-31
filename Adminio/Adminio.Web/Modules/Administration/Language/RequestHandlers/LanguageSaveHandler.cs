﻿using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Adminio.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Adminio.Administration.LanguageRow;


namespace Adminio.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}