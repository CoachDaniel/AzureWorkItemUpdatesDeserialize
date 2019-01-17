// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using WebApiClient;
//
//    var workItemHistoryItems = WorkItemHistoryItems.FromJson(jsonString);

namespace WebApiClient
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class WorkItemHistoryItems
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<Revisions> Revisions { get; set; }
    }

    public partial class Revisions
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("workItemId", NullValueHandling = NullValueHandling.Ignore)]
        public long? WorkItemId { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rev { get; set; }

        [JsonProperty("revisedBy", NullValueHandling = NullValueHandling.Ignore)]
        public RevisedBy RevisedBy { get; set; }

        [JsonProperty("revisedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RevisedDate { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Fields Fields { get; set; }

        [JsonProperty("relations", NullValueHandling = NullValueHandling.Ignore)]
        public Relations Relations { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public partial class Fields
    {
        [JsonProperty("System.Id", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority SystemId { get; set; }

        [JsonProperty("System.AreaId", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority SystemAreaId { get; set; }

        [JsonProperty("System.NodeName", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemNodeName { get; set; }

        [JsonProperty("System.AreaLevel1", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemAreaLevel1 { get; set; }

        [JsonProperty("System.AreaLevel2", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemAreaLevel2 { get; set; }

        [JsonProperty("System.AreaLevel3", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemAreaLevel3 { get; set; }

        [JsonProperty("System.AreaLevel4", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemAreaLevel4 { get; set; }

        [JsonProperty("System.Rev", NullValueHandling = NullValueHandling.Ignore)]
        public SystemIterationIdClass SystemRev { get; set; }

        [JsonProperty("System.AuthorizedDate", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedDateClass SystemAuthorizedDate { get; set; }

        [JsonProperty("System.RevisedDate", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedDateClass SystemRevisedDate { get; set; }

        [JsonProperty("System.IterationId", NullValueHandling = NullValueHandling.Ignore)]
        public SystemIterationIdClass SystemIterationId { get; set; }

        [JsonProperty("System.IterationLevel1", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemIterationLevel1 { get; set; }

        [JsonProperty("System.IterationLevel2", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemIterationLevel2 { get; set; }

        [JsonProperty("System.IterationLevel3", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedDateClass SystemIterationLevel3 { get; set; }

        [JsonProperty("System.WorkItemType", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemWorkItemType { get; set; }

        [JsonProperty("System.State", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemState { get; set; }

        [JsonProperty("System.Reason", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemReason { get; set; }

        [JsonProperty("System.AssignedTo", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAssignedToClass SystemAssignedTo { get; set; }

        [JsonProperty("System.CreatedDate", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemCreatedDate { get; set; }

        [JsonProperty("System.CreatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAssignedToClass SystemCreatedBy { get; set; }

        [JsonProperty("System.ChangedDate", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedDateClass SystemChangedDate { get; set; }

        [JsonProperty("System.ChangedBy", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedAsClass SystemChangedBy { get; set; }

        [JsonProperty("System.AuthorizedAs", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedAsClass SystemAuthorizedAs { get; set; }

        [JsonProperty("System.PersonId", NullValueHandling = NullValueHandling.Ignore)]
        public SystemIterationIdClass SystemPersonId { get; set; }

        [JsonProperty("System.Watermark", NullValueHandling = NullValueHandling.Ignore)]
        public SystemIterationIdClass SystemWatermark { get; set; }

        [JsonProperty("System.IsDeleted", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone SystemIsDeleted { get; set; }

        [JsonProperty("System.CommentCount", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority SystemCommentCount { get; set; }

        [JsonProperty("System.TeamProject", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemTeamProject { get; set; }

        [JsonProperty("System.AreaPath", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemAreaPath { get; set; }

        [JsonProperty("System.IterationPath", NullValueHandling = NullValueHandling.Ignore)]
        public SystemAuthorizedDateClass SystemIterationPath { get; set; }

        [JsonProperty("System.Title", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemTitle { get; set; }

        [JsonProperty("System.BoardColumn", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemBoardColumn { get; set; }

        [JsonProperty("System.BoardColumnDone", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone SystemBoardColumnDone { get; set; }

        [JsonProperty("Microsoft.VSTS.Scheduling.StoryPoints", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority MicrosoftVstsSchedulingStoryPoints { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.StateChangeDate", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog MicrosoftVstsCommonStateChangeDate { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.Priority", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority MicrosoftVstsCommonPriority { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.StackRank", NullValueHandling = NullValueHandling.Ignore)]
        public MicrosoftVstsCommonPriority MicrosoftVstsCommonStackRank { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ValueArea", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog MicrosoftVstsCommonValueArea { get; set; }

        [JsonProperty("WEF_E9F69D00917D459A99200571A091824A_System.ExtensionMarker", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone WefE9F69D00917D459A99200571A091824ASystemExtensionMarker { get; set; }

        [JsonProperty("WEF_E9F69D00917D459A99200571A091824A_Kanban.Column", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog WefE9F69D00917D459A99200571A091824AKanbanColumn { get; set; }

        [JsonProperty("WEF_E9F69D00917D459A99200571A091824A_Kanban.Column.Done", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone WefE9F69D00917D459A99200571A091824AKanbanColumnDone { get; set; }

        [JsonProperty("WEF_F7A7086E49FB4FDF9E02DB23E10FFC95_System.ExtensionMarker", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone WefF7A7086E49Fb4Fdf9E02Db23E10Ffc95SystemExtensionMarker { get; set; }

        [JsonProperty("WEF_F7A7086E49FB4FDF9E02DB23E10FFC95_Kanban.Column", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog WefF7A7086E49Fb4Fdf9E02Db23E10Ffc95KanbanColumn { get; set; }

        [JsonProperty("WEF_F7A7086E49FB4FDF9E02DB23E10FFC95_Kanban.Column.Done", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone WefF7A7086E49Fb4Fdf9E02Db23E10Ffc95KanbanColumnDone { get; set; }

        [JsonProperty("WEF_9A4419E6249F4C1ABF38144ACEED2825_System.ExtensionMarker", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone Wef9A4419E6249F4C1Abf38144Aceed2825SystemExtensionMarker { get; set; }

        [JsonProperty("WEF_9A4419E6249F4C1ABF38144ACEED2825_Kanban.Column", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog Wef9A4419E6249F4C1Abf38144Aceed2825KanbanColumn { get; set; }

        [JsonProperty("WEF_9A4419E6249F4C1ABF38144ACEED2825_Kanban.Column.Done", NullValueHandling = NullValueHandling.Ignore)]
        public SystemBoardColumnDone Wef9A4419E6249F4C1Abf38144Aceed2825KanbanColumnDone { get; set; }

        [JsonProperty("System.Description", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemDescription { get; set; }

        [JsonProperty("System.History", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemHistory { get; set; }

        [JsonProperty("System.Tags", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog SystemTags { get; set; }
    }

    public partial class MicrosoftVstsCommonPriority
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewValue { get; set; }
    }

    public partial class PuneHedgehog
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }
    }

    public partial class SystemAssignedToClass
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public RevisedBy NewValue { get; set; }
    }

    public partial class RevisedBy
    {
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public Links Links { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("uniqueName", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueName { get; set; }

        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string Descriptor { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public Avatar Avatar { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }
    }

    public partial class SystemAuthorizedAsClass
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public RevisedBy NewValue { get; set; }

        [JsonProperty("oldValue", NullValueHandling = NullValueHandling.Ignore)]
        public RevisedBy OldValue { get; set; }
    }

    public partial class SystemAuthorizedDateClass
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        [JsonProperty("oldValue", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }
    }

    public partial class SystemBoardColumnDone
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewValue { get; set; }
    }

    public partial class SystemIterationIdClass
    {
        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewValue { get; set; }

        [JsonProperty("oldValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? OldValue { get; set; }
    }

    public partial class Relations
    {
        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        public List<Added> Added { get; set; }
    }

    public partial class Added
    {
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attributes Attributes { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("isLocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }
    }

    

    
}
