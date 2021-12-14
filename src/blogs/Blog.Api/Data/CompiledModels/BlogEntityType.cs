﻿// <auto-generated />
using System;
using System.Reflection;
using Blog.Domain.AggregatesModel.BlogAggregate;
using Microsoft.EntityFrameworkCore.Metadata;
using Shared.SeedWork;
using BlogEntity = Blog.Domain.AggregatesModel.BlogAggregate.Blog;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Blog.Api
{
    internal partial class BlogEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Blog.Domain.AggregatesModel.BlogAggregate.Blog",
                typeof(BlogEntity),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(Guid),
                propertyInfo: typeof(Entity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Entity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("Relational:ColumnName", "id");
            id.AddAnnotation("Relational:ColumnType", "uuid");
            id.AddAnnotation("Relational:DefaultValueSql", "uuid_generate_v4()");

            var content = runtimeEntityType.AddProperty(
                "Content",
                typeof(string),
                propertyInfo: typeof(BlogEntity).GetProperty("Content", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BlogEntity).GetField("<Content>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            content.AddAnnotation("Relational:ColumnName", "content");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(ModifierTrackingEntity).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ModifierTrackingEntity).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdBy.AddAnnotation("Relational:ColumnName", "created_by");

            var createdById = runtimeEntityType.AddProperty(
                "CreatedById",
                typeof(Guid),
                propertyInfo: typeof(ModifierTrackingEntity).GetProperty("CreatedById", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ModifierTrackingEntity).GetField("<CreatedById>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            createdById.AddAnnotation("Relational:ColumnName", "created_by_id");

            var createdDate = runtimeEntityType.AddProperty(
                "CreatedDate",
                typeof(DateTimeOffset),
                propertyInfo: typeof(DateTrackingEntity).GetProperty("CreatedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DateTrackingEntity).GetField("<CreatedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            createdDate.AddAnnotation("Relational:ColumnName", "created_date");

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(BlogEntity).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BlogEntity).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 256);
            description.AddAnnotation("Relational:ColumnName", "description");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(ModifierTrackingEntity).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ModifierTrackingEntity).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "last_updated_by");

            var lastUpdatedById = runtimeEntityType.AddProperty(
                "LastUpdatedById",
                typeof(Guid),
                propertyInfo: typeof(ModifierTrackingEntity).GetProperty("LastUpdatedById", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ModifierTrackingEntity).GetField("<LastUpdatedById>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            lastUpdatedById.AddAnnotation("Relational:ColumnName", "last_updated_by_id");

            var lastUpdatedDate = runtimeEntityType.AddProperty(
                "LastUpdatedDate",
                typeof(DateTimeOffset),
                propertyInfo: typeof(DateTrackingEntity).GetProperty("LastUpdatedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DateTrackingEntity).GetField("<LastUpdatedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            lastUpdatedDate.AddAnnotation("Relational:ColumnName", "last_updated_date");

            var poster = runtimeEntityType.AddProperty(
                "Poster",
                typeof(string),
                propertyInfo: typeof(BlogEntity).GetProperty("Poster", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BlogEntity).GetField("<Poster>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            poster.AddAnnotation("Relational:ColumnName", "poster");

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(BlogStatus),
                propertyInfo: typeof(BlogEntity).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BlogEntity).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd);
            status.AddAnnotation("Relational:ColumnName", "status");
            status.AddAnnotation("Relational:DefaultValue", BlogStatus.Draft);

            var title = runtimeEntityType.AddProperty(
                "Title",
                typeof(string),
                propertyInfo: typeof(BlogEntity).GetProperty("Title", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BlogEntity).GetField("<Title>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 128);
            title.AddAnnotation("Relational:ColumnName", "title");

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "pk_blog");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "blog");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "blog");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
