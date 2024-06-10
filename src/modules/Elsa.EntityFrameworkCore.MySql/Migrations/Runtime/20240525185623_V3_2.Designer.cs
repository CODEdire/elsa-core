﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Runtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.MySql.Migrations.Runtime
{
    [DbContext(typeof(RuntimeElsaDbContext))]
    [Migration("20240525185623_V3_2")]
    partial class V3_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Elsa.KeyValues.Entities.SerializedKeyValuePair", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SerializedValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Key");

                    b.ToTable("KeyValuePairs", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.ActivityExecutionRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityNodeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("HasBookmarks")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedActivityStateCompressionAlgorithm")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedException")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedOutputs")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedProperties")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("StartedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityName");

                    b.HasIndex("ActivityNodeId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityNodeId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityTypeVersion");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_CompletedAt");

                    b.HasIndex("HasBookmarks")
                        .HasDatabaseName("IX_ActivityExecutionRecord_HasBookmarks");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_ActivityExecutionRecord_Status");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_WorkflowInstanceId");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType_ActivityTypeVersion");

                    b.ToTable("ActivityExecutionRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredBookmark", b =>
                {
                    b.Property<string>("BookmarkId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SerializedMetadata")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("longtext");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("BookmarkId");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_StoredBookmark_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_StoredBookmark_ActivityTypeName");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash" }, "IX_StoredBookmark_ActivityTypeName_Hash");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash", "WorkflowInstanceId" }, "IX_StoredBookmark_ActivityTypeName_Hash_WorkflowInstanceId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_StoredBookmark_CreatedAt");

                    b.HasIndex(new[] { "Hash" }, "IX_StoredBookmark_Hash");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_StoredBookmark_WorkflowInstanceId");

                    b.ToTable("Bookmarks", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredTrigger", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hash")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("longtext");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_StoredTrigger_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_StoredTrigger_Name");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionVersionId");

                    b.ToTable("Triggers", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityInstanceId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityNodeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<string>("ParentActivityInstanceId")
                        .HasColumnType("varchar(255)");

                    b.Property<long>("Sequence")
                        .HasColumnType("bigint");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("longtext");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("longtext");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("WorkflowVersion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityInstanceId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityName");

                    b.HasIndex("ActivityNodeId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityNodeId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityTypeVersion");

                    b.HasIndex("EventName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_EventName");

                    b.HasIndex("ParentActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ParentActivityInstanceId");

                    b.HasIndex("Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Sequence");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionVersionId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.HasIndex("WorkflowVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowVersion");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType_ActivityTypeVersion");

                    b.HasIndex("Timestamp", "Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp_Sequence");

                    b.ToTable("WorkflowExecutionLogRecords", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
