﻿using uFluent;
using uFluent.Consts;
using uFluent.Migrate;
using Umbraco.Core;

namespace uFluentExample.uFluent.Migrate.Migrations
{
    public class Article : IUmbracoMigration
    {
        public void Migrate()
        {
            var homepageDocType = DocumentType.Get("Homepage");

            var categoryDocType = DocumentType.Get("Category");

            var articleTemplate = Template.Create("Article", "Article");
            articleTemplate.Save();

            var articleDocType = DocumentType.Create("Article", "Article")
                .SetParent(homepageDocType)
                .SetDefaultTemplate(articleTemplate)
                .Save();

            categoryDocType.AddAllowedChildNodeType(articleDocType)
                           .Save();
        }
    }
}