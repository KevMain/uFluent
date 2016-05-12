﻿using uFluent;
using uFluent.Migrate;

namespace uFluentExample.uFluent.Migrate.Migrations
{
    public class ArticleClearNewMasterTemplate : IUmbracoMigration
    {
        public void Migrate()
        {
            var template = Template.Get("NewArticleTemplate");
            template.ClearMasterTemplate();
            template.Save();
        }
    }
}