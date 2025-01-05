using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage
{

    public class UrlPaths
    {
        [JsonProperty("/rest/api/3/announcementBanner", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AnnouncementBanner RestApi3AnnouncementBanner { get; set; }

        [JsonProperty("/rest/api/3/app/field/context/configuration/list", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AppFieldContextConfigurationList RestApi3AppFieldContextConfigurationList { get; set; }

        [JsonProperty("/rest/api/3/app/field/value", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AppFieldValue RestApi3AppFieldValue { get; set; }

        [JsonProperty("/rest/api/3/app/field/{fieldIdOrKey}/context/configuration", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AppFieldFieldIdOrKeyContextConfiguration RestApi3AppFieldFieldIdOrKeyContextConfiguration { get; set; }

        [JsonProperty("/rest/api/3/app/field/{fieldIdOrKey}/value", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AppFieldFieldIdOrKeyValue RestApi3AppFieldFieldIdOrKeyValue { get; set; }

        [JsonProperty("/rest/api/3/application-properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationProperties RestApi3ApplicationProperties { get; set; }

        [JsonProperty("/rest/api/3/application-properties/advanced-settings", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationPropertiesAdvancedSettingsClass RestApi3ApplicationPropertiesAdvancedSettings { get; set; }

        [JsonProperty("/rest/api/3/application-properties/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationPropertiesId RestApi3ApplicationPropertiesId { get; set; }

        [JsonProperty("/rest/api/3/applicationrole", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Applicationrole RestApi3Applicationrole { get; set; }

        [JsonProperty("/rest/api/3/applicationrole/{key}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationroleKey RestApi3ApplicationroleKey { get; set; }

        [JsonProperty("/rest/api/3/attachment/content/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentContentId RestApi3AttachmentContentId { get; set; }

        [JsonProperty("/rest/api/3/attachment/meta", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3AttachmentMeta { get; set; }

        [JsonProperty("/rest/api/3/attachment/thumbnail/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentThumbnailId RestApi3AttachmentThumbnailId { get; set; }

        [JsonProperty("/rest/api/3/attachment/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentId RestApi3AttachmentId { get; set; }

        [JsonProperty("/rest/api/3/attachment/{id}/expand/human", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_AttachmentIdExpand RestApi3AttachmentIdExpandHuman { get; set; }

        [JsonProperty("/rest/api/3/attachment/{id}/expand/raw", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_AttachmentIdExpand RestApi3AttachmentIdExpandRaw { get; set; }

        [JsonProperty("/rest/api/3/auditing/record", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AuditingRecord RestApi3AuditingRecord { get; set; }

        [JsonProperty("/rest/api/3/avatar/{type}/system", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AvatarTypeSystem RestApi3AvatarTypeSystem { get; set; }

        [JsonProperty("/rest/api/3/bulk/issues/delete", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkIssuesDelete RestApi3BulkIssuesDelete { get; set; }

        [JsonProperty("/rest/api/3/bulk/issues/fields", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkIssuesFields RestApi3BulkIssuesFields { get; set; }

        [JsonProperty("/rest/api/3/bulk/issues/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkIssuesMove RestApi3BulkIssuesMove { get; set; }

        [JsonProperty("/rest/api/3/bulk/issues/transition", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkIssuesTransition RestApi3BulkIssuesTransition { get; set; }

        [JsonProperty("/rest/api/3/bulk/queue/{taskId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkQueueTaskIdClass RestApi3BulkQueueTaskId { get; set; }

        [JsonProperty("/rest/api/3/changelog/bulkfetch", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Tch RestApi3ChangelogBulkfetch { get; set; }

        [JsonProperty("/rest/api/3/classification-levels", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3ClassificationLevels { get; set; }

        [JsonProperty("/rest/api/3/comment/list", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentList RestApi3CommentList { get; set; }

        [JsonProperty("/rest/api/3/comment/{commentId}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentCommentIdPropertiesClass RestApi3CommentCommentIdProperties { get; set; }

        [JsonProperty("/rest/api/3/comment/{commentId}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentCommentIdPropertiesPropertyKey RestApi3CommentCommentIdPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/component", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Component RestApi3Component { get; set; }

        [JsonProperty("/rest/api/3/component/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentId RestApi3ComponentId { get; set; }

        [JsonProperty("/rest/api/3/component/{id}/relatedIssueCounts", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3ComponentIdRelatedIssueCounts { get; set; }

        [JsonProperty("/rest/api/3/configuration", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3Configuration { get; set; }

        [JsonProperty("/rest/api/3/configuration/timetracking", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ConfigurationTimetracking RestApi3ConfigurationTimetracking { get; set; }

        [JsonProperty("/rest/api/3/configuration/timetracking/list", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationPropertiesAdvancedSettingsClass RestApi3ConfigurationTimetrackingList { get; set; }

        [JsonProperty("/rest/api/3/configuration/timetracking/options", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ConfigurationTimetrackingOptions RestApi3ConfigurationTimetrackingOptions { get; set; }

        [JsonProperty("/rest/api/3/customFieldOption/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3CustomFieldOptionId { get; set; }

        [JsonProperty("/rest/api/3/dashboard", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Dashboard RestApi3Dashboard { get; set; }

        [JsonProperty("/rest/api/3/dashboard/bulk/edit", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardBulkEdit RestApi3DashboardBulkEdit { get; set; }

        [JsonProperty("/rest/api/3/dashboard/gadgets", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Dashboard RestApi3DashboardGadgets { get; set; }

        [JsonProperty("/rest/api/3/dashboard/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Dashboard RestApi3DashboardSearch { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{dashboardId}/gadget", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardDashboardIdGadget RestApi3DashboardDashboardIdGadget { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{dashboardId}/gadget/{gadgetId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardDashboardIdGadgetGadgetId RestApi3DashboardDashboardIdGadgetGadgetId { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{dashboardId}/items/{itemId}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3BulkQueueTaskIdClass RestApi3DashboardDashboardIdItemsItemIdProperties { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{dashboardId}/items/{itemId}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardDashboardIdItemsItemIdPropertiesPropertyKey RestApi3DashboardDashboardIdItemsItemIdPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardId RestApi3DashboardId { get; set; }

        [JsonProperty("/rest/api/3/dashboard/{id}/copy", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3DashboardIdCopy RestApi3DashboardIdCopy { get; set; }

        [JsonProperty("/rest/api/3/data-policy", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_DataPolicy RestApi3DataPolicy { get; set; }

        [JsonProperty("/rest/api/3/data-policy/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_DataPolicy RestApi3DataPolicyProject { get; set; }

        [JsonProperty("/rest/api/3/events", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ApplicationPropertiesAdvancedSettingsClass RestApi3Events { get; set; }

        [JsonProperty("/rest/api/3/expression/analyse", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ExpressionAnalyse RestApi3ExpressionAnalyse { get; set; }

        [JsonProperty("/rest/api/3/expression/eval", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ExpressionEval RestApi3ExpressionEval { get; set; }

        [JsonProperty("/rest/api/3/expression/evaluate", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ExpressionEvaluate RestApi3ExpressionEvaluate { get; set; }

        [JsonProperty("/rest/api/3/field", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Field RestApi3Field { get; set; }

        [JsonProperty("/rest/api/3/field/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldSearch RestApi3FieldSearch { get; set; }

        [JsonProperty("/rest/api/3/field/search/trashed", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldSearchTrashed RestApi3FieldSearchTrashed { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldId RestApi3FieldFieldId { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContext RestApi3FieldFieldIdContext { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextDefaultValue RestApi3FieldFieldIdContextDefaultValue { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/issuetypemapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextIssuetypemapping RestApi3FieldFieldIdContextIssuetypemapping { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextMapping RestApi3FieldFieldIdContextMapping { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/projectmapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextProjectmapping RestApi3FieldFieldIdContextProjectmapping { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdClass RestApi3FieldFieldIdContextContextId { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdIssuetype RestApi3FieldFieldIdContextContextIdIssuetype { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/issuetype/remove", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldFieldIdContextContextIdRemove RestApi3FieldFieldIdContextContextIdIssuetypeRemove { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/option", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOption RestApi3FieldFieldIdContextContextIdOption { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/option/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionMoveClass RestApi3FieldFieldIdContextContextIdOptionMove { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/option/{optionId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionOptionId RestApi3FieldFieldIdContextContextIdOptionOptionId { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/option/{optionId}/issue", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionOptionIdIssue RestApi3FieldFieldIdContextContextIdOptionOptionIdIssue { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionMoveClass RestApi3FieldFieldIdContextContextIdProject { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/context/{contextId}/project/remove", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldFieldIdContextContextIdRemove RestApi3FieldFieldIdContextContextIdProjectRemove { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/contexts", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextsClass RestApi3FieldFieldIdContexts { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldId}/screens", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextsClass RestApi3FieldFieldIdScreens { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldKey}/option", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldKeyOption RestApi3FieldFieldKeyOption { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldKey}/option/suggestions/edit", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldFieldKeyOptionSuggestions RestApi3FieldFieldKeyOptionSuggestionsEdit { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldKey}/option/suggestions/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldFieldKeyOptionSuggestions RestApi3FieldFieldKeyOptionSuggestionsSearch { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldKey}/option/{optionId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldKeyOptionOptionId RestApi3FieldFieldKeyOptionOptionId { get; set; }

        [JsonProperty("/rest/api/3/field/{fieldKey}/option/{optionId}/issue", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldKeyOptionOptionIdIssue RestApi3FieldFieldKeyOptionOptionIdIssue { get; set; }

        [JsonProperty("/rest/api/3/field/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldId RestApi3FieldId { get; set; }

        [JsonProperty("/rest/api/3/field/{id}/restore", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldId RestApi3FieldIdRestore { get; set; }

        [JsonProperty("/rest/api/3/field/{id}/trash", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_FieldId RestApi3FieldIdTrash { get; set; }

        [JsonProperty("/rest/api/3/fieldconfiguration", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Fieldconfiguration RestApi3Fieldconfiguration { get; set; }

        [JsonProperty("/rest/api/3/fieldconfiguration/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationId RestApi3FieldconfigurationId { get; set; }

        [JsonProperty("/rest/api/3/fieldconfiguration/{id}/fields", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationIdFields RestApi3FieldconfigurationIdFields { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Fieldconfigurationscheme RestApi3Fieldconfigurationscheme { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationschemeMapping RestApi3FieldconfigurationschemeMapping { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_NschemeProject RestApi3FieldconfigurationschemeProject { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationschemeId RestApi3FieldconfigurationschemeId { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme/{id}/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationschemeIdMapping RestApi3FieldconfigurationschemeIdMapping { get; set; }

        [JsonProperty("/rest/api/3/fieldconfigurationscheme/{id}/mapping/delete", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldconfigurationschemeIdMappingDelete RestApi3FieldconfigurationschemeIdMappingDelete { get; set; }

        [JsonProperty("/rest/api/3/filter", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Filter RestApi3Filter { get; set; }

        [JsonProperty("/rest/api/3/filter/defaultShareScope", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterDefaultShareScope RestApi3FilterDefaultShareScope { get; set; }

        [JsonProperty("/rest/api/3/filter/favourite", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterFavouriteClass RestApi3FilterFavourite { get; set; }

        [JsonProperty("/rest/api/3/filter/my", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterFavouriteClass RestApi3FilterMy { get; set; }

        [JsonProperty("/rest/api/3/filter/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterSearch RestApi3FilterSearch { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterId RestApi3FilterId { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}/columns", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterIdColumns RestApi3FilterIdColumns { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}/favourite", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterIdFavourite RestApi3FilterIdFavourite { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}/owner", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterIdOwner RestApi3FilterIdOwner { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}/permission", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterIdPermission RestApi3FilterIdPermission { get; set; }

        [JsonProperty("/rest/api/3/filter/{id}/permission/{permissionId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterIdPermissionPermissionId RestApi3FilterIdPermissionPermissionId { get; set; }

        [JsonProperty("/rest/api/3/group", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Group RestApi3Group { get; set; }

        [JsonProperty("/rest/api/3/group/bulk", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3GroupBulk RestApi3GroupBulk { get; set; }

        [JsonProperty("/rest/api/3/group/member", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3GroupMember RestApi3GroupMember { get; set; }

        [JsonProperty("/rest/api/3/group/user", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3GroupUser RestApi3GroupUser { get; set; }

        [JsonProperty("/rest/api/3/groups/picker", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3GroupsPicker RestApi3GroupsPicker { get; set; }

        [JsonProperty("/rest/api/3/groupuserpicker", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Groupuserpicker RestApi3Groupuserpicker { get; set; }

        [JsonProperty("/rest/api/3/instance/license", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3InstanceLicense { get; set; }

        [JsonProperty("/rest/api/3/issue", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Issue RestApi3Issue { get; set; }

        [JsonProperty("/rest/api/3/issue/archive", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueArchive RestApi3IssueArchive { get; set; }

        [JsonProperty("/rest/api/3/issue/bulk", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulk RestApi3IssueBulk { get; set; }

        [JsonProperty("/rest/api/3/issue/bulkfetch", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3IssueBulkfetch { get; set; }

        [JsonProperty("/rest/api/3/issue/createmeta", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3IssueCreatemeta { get; set; }

        [JsonProperty("/rest/api/3/issue/createmeta/{projectIdOrKey}/issuetypes", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_IssueCreatemetaProjectIdOrKeyIssuetypes RestApi3IssueCreatemetaProjectIdOrKeyIssuetypes { get; set; }

        [JsonProperty("/rest/api/3/issue/createmeta/{projectIdOrKey}/issuetypes/{issueTypeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_IssueCreatemetaProjectIdOrKeyIssuetypes RestApi3IssueCreatemetaProjectIdOrKeyIssuetypesIssueTypeId { get; set; }

        [JsonProperty("/rest/api/3/issue/limit/report", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueLimitReport RestApi3IssueLimitReport { get; set; }

        [JsonProperty("/rest/api/3/issue/picker", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuePicker RestApi3IssuePicker { get; set; }

        [JsonProperty("/rest/api/3/issue/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueProperties RestApi3IssueProperties { get; set; }

        [JsonProperty("/rest/api/3/issue/properties/multi", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuePropertiesMulti RestApi3IssuePropertiesMulti { get; set; }

        [JsonProperty("/rest/api/3/issue/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuePropertiesPropertyKey RestApi3IssuePropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/issue/unarchive", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueUnarchive RestApi3IssueUnarchive { get; set; }

        [JsonProperty("/rest/api/3/issue/watching", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueWatching RestApi3IssueWatching { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKey RestApi3IssueIssueIdOrKey { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/assignee", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyAssignee RestApi3IssueIssueIdOrKeyAssignee { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/attachments", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyAttachments RestApi3IssueIssueIdOrKeyAttachments { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/changelog", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyChangelog RestApi3IssueIssueIdOrKeyChangelog { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/changelog/list", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyChangelogList RestApi3IssueIssueIdOrKeyChangelogList { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/comment", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyComment RestApi3IssueIssueIdOrKeyComment { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/comment/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyCommentId RestApi3IssueIssueIdOrKeyCommentId { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/editmeta", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyEditmeta RestApi3IssueIssueIdOrKeyEditmeta { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/notify", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyNotify RestApi3IssueIssueIdOrKeyNotify { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyPropertiesClass RestApi3IssueIssueIdOrKeyProperties { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyPropertiesPropertyKey RestApi3IssueIssueIdOrKeyPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/remotelink", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyRemotelink RestApi3IssueIssueIdOrKeyRemotelink { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/remotelink/{linkId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyRemotelinkLinkId RestApi3IssueIssueIdOrKeyRemotelinkLinkId { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/transitions", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyTransitions RestApi3IssueIssueIdOrKeyTransitions { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/votes", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyVotes RestApi3IssueIssueIdOrKeyVotes { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/watchers", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWatchers RestApi3IssueIssueIdOrKeyWatchers { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/worklog", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklog RestApi3IssueIssueIdOrKeyWorklog { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/worklog/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklogMove RestApi3IssueIssueIdOrKeyWorklogMove { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/worklog/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklogId RestApi3IssueIssueIdOrKeyWorklogId { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/worklog/{worklogId}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklogWorklogIdPropertiesClass RestApi3IssueIssueIdOrKeyWorklogWorklogIdProperties { get; set; }

        [JsonProperty("/rest/api/3/issue/{issueIdOrKey}/worklog/{worklogId}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklogWorklogIdPropertiesPropertyKey RestApi3IssueIssueIdOrKeyWorklogWorklogIdPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/issueLink", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueLink RestApi3IssueLink { get; set; }

        [JsonProperty("/rest/api/3/issueLink/{linkId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueLinkLinkId RestApi3IssueLinkLinkId { get; set; }

        [JsonProperty("/rest/api/3/issueLinkType", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueLinkType RestApi3IssueLinkType { get; set; }

        [JsonProperty("/rest/api/3/issueLinkType/{issueLinkTypeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueLinkTypeIssueLinkTypeId RestApi3IssueLinkTypeIssueLinkTypeId { get; set; }

        [JsonProperty("/rest/api/3/issues/archive/export", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesArchiveExport RestApi3IssuesArchiveExport { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Issuesecurityschemes RestApi3Issuesecurityschemes { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/level", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevel RestApi3IssuesecurityschemesLevel { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/level/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevelDefaultClass RestApi3IssuesecurityschemesLevelDefault { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/level/member", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevelMember RestApi3IssuesecurityschemesLevelMember { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesProject RestApi3IssuesecurityschemesProject { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSearch RestApi3IssuesecurityschemesSearch { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesId RestApi3IssuesecurityschemesId { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{issueSecuritySchemeId}/members", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesIssueSecuritySchemeIdMembers RestApi3IssuesecurityschemesIssueSecuritySchemeIdMembers { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{schemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdClass RestApi3IssuesecurityschemesSchemeId { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{schemeId}/level", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdLevelClass RestApi3IssuesecurityschemesSchemeIdLevel { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{schemeId}/level/{levelId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdLevelLevelId RestApi3IssuesecurityschemesSchemeIdLevelLevelId { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{schemeId}/level/{levelId}/member", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdLevelClass RestApi3IssuesecurityschemesSchemeIdLevelLevelIdMember { get; set; }

        [JsonProperty("/rest/api/3/issuesecurityschemes/{schemeId}/level/{levelId}/member/{memberId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdClass RestApi3IssuesecurityschemesSchemeIdLevelLevelIdMemberMemberId { get; set; }

        [JsonProperty("/rest/api/3/issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Issuetype RestApi3Issuetype { get; set; }

        [JsonProperty("/rest/api/3/issuetype/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeProject RestApi3IssuetypeProject { get; set; }

        [JsonProperty("/rest/api/3/issuetype/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeId RestApi3IssuetypeId { get; set; }

        [JsonProperty("/rest/api/3/issuetype/{id}/alternatives", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeIdAlternativesClass RestApi3IssuetypeIdAlternatives { get; set; }

        [JsonProperty("/rest/api/3/issuetype/{id}/avatar2", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3__Avatar2 RestApi3IssuetypeIdAvatar2 { get; set; }

        [JsonProperty("/rest/api/3/issuetype/{issueTypeId}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeIssueTypeIdProperties RestApi3IssuetypeIssueTypeIdProperties { get; set; }

        [JsonProperty("/rest/api/3/issuetype/{issueTypeId}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeIssueTypeIdPropertiesPropertyKey RestApi3IssuetypeIssueTypeIdPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Issuetypescheme RestApi3Issuetypescheme { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_IssuetypescschemeMapping RestApi3IssuetypeschemeMapping { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeschemeProject RestApi3IssuetypeschemeProject { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/{issueTypeSchemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdClass RestApi3IssuetypeschemeIssueTypeSchemeId { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/{issueTypeSchemeId}/issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionMoveClass RestApi3IssuetypeschemeIssueTypeSchemeIdIssuetype { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/{issueTypeSchemeId}/issuetype/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextContextIdOptionMoveClass RestApi3IssuetypeschemeIssueTypeSchemeIdIssuetypeMove { get; set; }

        [JsonProperty("/rest/api/3/issuetypescheme/{issueTypeSchemeId}/issuetype/{issueTypeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeschemeIssueTypeSchemeIdIssuetypeIssueTypeId RestApi3IssuetypeschemeIssueTypeSchemeIdIssuetypeIssueTypeId { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Issuetypescreenscheme RestApi3Issuetypescreenscheme { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_IssuetypescschemeMapping RestApi3IssuetypescreenschemeMapping { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_NschemeProject RestApi3IssuetypescreenschemeProject { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/{issueTypeScreenSchemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypescreenschemeIssueTypeScreenSchemeId RestApi3IssuetypescreenschemeIssueTypeScreenSchemeId { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/{issueTypeScreenSchemeId}/mapping", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMapping RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMapping { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/{issueTypeScreenSchemeId}/mapping/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMappingDefault RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMappingDefault { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/{issueTypeScreenSchemeId}/mapping/remove", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMappingRemove RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdMappingRemove { get; set; }

        [JsonProperty("/rest/api/3/issuetypescreenscheme/{issueTypeScreenSchemeId}/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdProject RestApi3IssuetypescreenschemeIssueTypeScreenSchemeIdProject { get; set; }

        [JsonProperty("/rest/api/3/jql/autocompletedata", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedata RestApi3JqlAutocompletedata { get; set; }

        [JsonProperty("/rest/api/3/jql/autocompletedata/suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3JqlAutocompletedataSuggestions { get; set; }

        [JsonProperty("/rest/api/3/jql/function/computation", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlFunctionComputation RestApi3JqlFunctionComputation { get; set; }

        [JsonProperty("/rest/api/3/jql/function/computation/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlFunctionComputationSearch RestApi3JqlFunctionComputationSearch { get; set; }

        [JsonProperty("/rest/api/3/jql/match", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Tch RestApi3JqlMatch { get; set; }

        [JsonProperty("/rest/api/3/jql/parse", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlParse RestApi3JqlParse { get; set; }

        [JsonProperty("/rest/api/3/jql/pdcleaner", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlPdcleaner RestApi3JqlPdcleaner { get; set; }

        [JsonProperty("/rest/api/3/jql/sanitize", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlSanitize RestApi3JqlSanitize { get; set; }

        [JsonProperty("/rest/api/3/label", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Label RestApi3Label { get; set; }

        [JsonProperty("/rest/api/3/license/approximateLicenseCount", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_LicenseApproximateLicenseCount RestApi3LicenseApproximateLicenseCount { get; set; }

        [JsonProperty("/rest/api/3/license/approximateLicenseCount/product/{applicationKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_LicenseApproximateLicenseCount RestApi3LicenseApproximateLicenseCountProductApplicationKey { get; set; }

        [JsonProperty("/rest/api/3/mypermissions", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Mypermissions RestApi3Mypermissions { get; set; }

        [JsonProperty("/rest/api/3/mypreferences", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Mypreferences RestApi3Mypreferences { get; set; }

        [JsonProperty("/rest/api/3/mypreferences/locale", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3MypreferencesLocale RestApi3MypreferencesLocale { get; set; }

        [JsonProperty("/rest/api/3/myself", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3Myself { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Notificationscheme RestApi3Notificationscheme { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3NotificationschemeProject RestApi3NotificationschemeProject { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3NotificationschemeId RestApi3NotificationschemeId { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme/{id}/notification", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdLevelClass RestApi3NotificationschemeIdNotification { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme/{notificationSchemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdClass RestApi3NotificationschemeNotificationSchemeId { get; set; }

        [JsonProperty("/rest/api/3/notificationscheme/{notificationSchemeId}/notification/{notificationId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdClass RestApi3NotificationschemeNotificationSchemeIdNotificationNotificationId { get; set; }

        [JsonProperty("/rest/api/3/permissions", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FieldFieldIdContextsClass RestApi3Permissions { get; set; }

        [JsonProperty("/rest/api/3/permissions/check", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PermissionsCheck RestApi3PermissionsCheck { get; set; }

        [JsonProperty("/rest/api/3/permissions/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PermissionsProject RestApi3PermissionsProject { get; set; }

        [JsonProperty("/rest/api/3/permissionscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Permissionscheme RestApi3Permissionscheme { get; set; }

        [JsonProperty("/rest/api/3/permissionscheme/{schemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PermissionschemeSchemeId RestApi3PermissionschemeSchemeId { get; set; }

        [JsonProperty("/rest/api/3/permissionscheme/{schemeId}/permission", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PermissionschemeSchemeIdPermission RestApi3PermissionschemeSchemeIdPermission { get; set; }

        [JsonProperty("/rest/api/3/permissionscheme/{schemeId}/permission/{permissionId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PermissionschemeSchemeIdPermissionPermissionId RestApi3PermissionschemeSchemeIdPermissionPermissionId { get; set; }

        [JsonProperty("/rest/api/3/plans/plan", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlan RestApi3PlansPlan { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlanPlanId RestApi3PlansPlanPlanId { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/archive", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_PlansPlanPlanId RestApi3PlansPlanPlanIdArchive { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/duplicate", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlanPlanIdDuplicate RestApi3PlansPlanPlanIdDuplicate { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/team", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlanPlanIdTeam RestApi3PlansPlanPlanIdTeam { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/team/atlassian", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlanPlanIdTeamAtlassian RestApi3PlansPlanPlanIdTeamAtlassian { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/team/atlassian/{atlassianTeamId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_PlansPlanPlanIdTeamTeamId RestApi3PlansPlanPlanIdTeamAtlassianAtlassianTeamId { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/team/planonly", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PlansPlanPlanIdTeamPlanonly RestApi3PlansPlanPlanIdTeamPlanonly { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/team/planonly/{planOnlyTeamId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_PlansPlanPlanIdTeamTeamId RestApi3PlansPlanPlanIdTeamPlanonlyPlanOnlyTeamId { get; set; }

        [JsonProperty("/rest/api/3/plans/plan/{planId}/trash", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_PlansPlanPlanId RestApi3PlansPlanPlanIdTrash { get; set; }

        [JsonProperty("/rest/api/3/priority", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Priority RestApi3Priority { get; set; }

        [JsonProperty("/rest/api/3/priority/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevelDefaultClass RestApi3PriorityDefault { get; set; }

        [JsonProperty("/rest/api/3/priority/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesSchemeIdLevelClass RestApi3PriorityMove { get; set; }

        [JsonProperty("/rest/api/3/priority/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3__Search RestApi3PrioritySearch { get; set; }

        [JsonProperty("/rest/api/3/priority/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PriorityId RestApi3PriorityId { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Priorityscheme RestApi3Priorityscheme { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme/mappings", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3PriorityschemeMappings { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme/priorities/available", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3PriorityschemePrioritiesAvailable { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme/{schemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3PriorityschemeSchemeId RestApi3PriorityschemeSchemeId { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme/{schemeId}/priorities", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3PriorityschemeSchemeIdPriorities { get; set; }

        [JsonProperty("/rest/api/3/priorityscheme/{schemeId}/projects", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3PriorityschemeSchemeIdProjects { get; set; }

        [JsonProperty("/rest/api/3/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Project RestApi3Project { get; set; }

        [JsonProperty("/rest/api/3/project/recent", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectRecent RestApi3ProjectRecent { get; set; }

        [JsonProperty("/rest/api/3/project/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectSearch RestApi3ProjectSearch { get; set; }

        [JsonProperty("/rest/api/3/project/type", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterFavouriteClass RestApi3ProjectType { get; set; }

        [JsonProperty("/rest/api/3/project/type/accessible", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectTypeAccessible RestApi3ProjectTypeAccessible { get; set; }

        [JsonProperty("/rest/api/3/project/type/{projectTypeKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_ProjectTypeProjectTypeKey RestApi3ProjectTypeProjectTypeKey { get; set; }

        [JsonProperty("/rest/api/3/project/type/{projectTypeKey}/accessible", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_ProjectTypeProjectTypeKey RestApi3ProjectTypeProjectTypeKeyAccessible { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKey RestApi3ProjectProjectIdOrKey { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/archive", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyArchive RestApi3ProjectProjectIdOrKeyArchive { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/avatar", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyAvatar RestApi3ProjectProjectIdOrKeyAvatar { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/avatar/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyAvatarId RestApi3ProjectProjectIdOrKeyAvatarId { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/avatar2", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3__Avatar2 RestApi3ProjectProjectIdOrKeyAvatar2 { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/avatars", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3ProjectProjectIdOrKeyAvatars { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/classification-level/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyClassificationLevelDefault RestApi3ProjectProjectIdOrKeyClassificationLevelDefault { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/component", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyComponent RestApi3ProjectProjectIdOrKeyComponent { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/components", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyComponents RestApi3ProjectProjectIdOrKeyComponents { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/delete", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyDeleteClass RestApi3ProjectProjectIdOrKeyDelete { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/features", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentCommentIdPropertiesClass RestApi3ProjectProjectIdOrKeyFeatures { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/features/{featureKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyFeaturesFeatureKey RestApi3ProjectProjectIdOrKeyFeaturesFeatureKey { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentCommentIdPropertiesClass RestApi3ProjectProjectIdOrKeyProperties { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyPropertiesPropertyKey RestApi3ProjectProjectIdOrKeyPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/restore", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyRestoreClass RestApi3ProjectProjectIdOrKeyRestore { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/role", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyRole RestApi3ProjectProjectIdOrKeyRole { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/role/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyRoleId RestApi3ProjectProjectIdOrKeyRoleId { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/roledetails", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyRoledetails RestApi3ProjectProjectIdOrKeyRoledetails { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/statuses", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuetypeIdAlternativesClass RestApi3ProjectProjectIdOrKeyStatuses { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/version", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyVersion RestApi3ProjectProjectIdOrKeyVersion { get; set; }

        [JsonProperty("/rest/api/3/project/{projectIdOrKey}/versions", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyVersions RestApi3ProjectProjectIdOrKeyVersions { get; set; }

        [JsonProperty("/rest/api/3/project/{projectId}/email", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdEmail RestApi3ProjectProjectIdEmail { get; set; }

        [JsonProperty("/rest/api/3/project/{projectId}/hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdHierarchy RestApi3ProjectProjectIdHierarchy { get; set; }

        [JsonProperty("/rest/api/3/project/{projectKeyOrId}/issuesecuritylevelscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3CommentCommentIdPropertiesClass RestApi3ProjectProjectKeyOrIdIssuesecuritylevelscheme { get; set; }

        [JsonProperty("/rest/api/3/project/{projectKeyOrId}/notificationscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyWorklogWorklogIdPropertiesClass RestApi3ProjectProjectKeyOrIdNotificationscheme { get; set; }

        [JsonProperty("/rest/api/3/project/{projectKeyOrId}/permissionscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectKeyOrIdPermissionscheme RestApi3ProjectProjectKeyOrIdPermissionscheme { get; set; }

        [JsonProperty("/rest/api/3/project/{projectKeyOrId}/securitylevel", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueIssueIdOrKeyPropertiesClass RestApi3ProjectProjectKeyOrIdSecuritylevel { get; set; }

        [JsonProperty("/rest/api/3/projectCategory", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectCategory RestApi3ProjectCategory { get; set; }

        [JsonProperty("/rest/api/3/projectCategory/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectCategoryId RestApi3ProjectCategoryId { get; set; }

        [JsonProperty("/rest/api/3/projectvalidate/key", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3ProjectvalidateKey { get; set; }

        [JsonProperty("/rest/api/3/projectvalidate/validProjectKey", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectvalidateValidProjectKey RestApi3ProjectvalidateValidProjectKey { get; set; }

        [JsonProperty("/rest/api/3/projectvalidate/validProjectName", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectvalidateValidProjectName RestApi3ProjectvalidateValidProjectName { get; set; }

        [JsonProperty("/rest/api/3/resolution", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Resolution RestApi3Resolution { get; set; }

        [JsonProperty("/rest/api/3/resolution/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevelDefaultClass RestApi3ResolutionDefault { get; set; }

        [JsonProperty("/rest/api/3/resolution/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssuesecurityschemesLevelDefaultClass RestApi3ResolutionMove { get; set; }

        [JsonProperty("/rest/api/3/resolution/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3__Search RestApi3ResolutionSearch { get; set; }

        [JsonProperty("/rest/api/3/resolution/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ResolutionId RestApi3ResolutionId { get; set; }

        [JsonProperty("/rest/api/3/role", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Role RestApi3Role { get; set; }

        [JsonProperty("/rest/api/3/role/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3RoleId RestApi3RoleId { get; set; }

        [JsonProperty("/rest/api/3/role/{id}/actors", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3RoleIdActors RestApi3RoleIdActors { get; set; }

        [JsonProperty("/rest/api/3/screens", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Screens RestApi3Screens { get; set; }

        [JsonProperty("/rest/api/3/screens/addToDefault/{fieldId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensAddToDefaultFieldId RestApi3ScreensAddToDefaultFieldId { get; set; }

        [JsonProperty("/rest/api/3/screens/tabs", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensTabs RestApi3ScreensTabs { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenId RestApi3ScreensScreenId { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/availableFields", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenIdAvailableFields RestApi3ScreensScreenIdAvailableFields { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenIdTabs RestApi3ScreensScreenIdTabs { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs/{tabId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenIdTabsTabId RestApi3ScreensScreenIdTabsTabId { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs/{tabId}/fields", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenIdTabsTabIdFields RestApi3ScreensScreenIdTabsTabIdFields { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs/{tabId}/fields/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreensScreenIdTabsTabIdFieldsId RestApi3ScreensScreenIdTabsTabIdFieldsId { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs/{tabId}/fields/{id}/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_ScreensScreenIdTabsTabId RestApi3ScreensScreenIdTabsTabIdFieldsIdMove { get; set; }

        [JsonProperty("/rest/api/3/screens/{screenId}/tabs/{tabId}/move/{pos}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_ScreensScreenIdTabsTabId RestApi3ScreensScreenIdTabsTabIdMovePos { get; set; }

        [JsonProperty("/rest/api/3/screenscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Screenscheme RestApi3Screenscheme { get; set; }

        [JsonProperty("/rest/api/3/screenscheme/{screenSchemeId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ScreenschemeScreenSchemeId RestApi3ScreenschemeScreenSchemeId { get; set; }

        [JsonProperty("/rest/api/3/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Search RestApi3Search { get; set; }

        [JsonProperty("/rest/api/3/search/approximate-count", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3SearchApproximateCount { get; set; }

        [JsonProperty("/rest/api/3/search/id", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3SearchId { get; set; }

        [JsonProperty("/rest/api/3/search/jql", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3SearchJql RestApi3SearchJql { get; set; }

        [JsonProperty("/rest/api/3/securitylevel/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3SecuritylevelId { get; set; }

        [JsonProperty("/rest/api/3/serverInfo", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3ServerInfo { get; set; }

        [JsonProperty("/rest/api/3/settings/columns", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3SettingsColumns RestApi3SettingsColumns { get; set; }

        [JsonProperty("/rest/api/3/status", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterFavouriteClass RestApi3Status { get; set; }

        [JsonProperty("/rest/api/3/status/{idOrName}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3StatusIdOrName { get; set; }

        [JsonProperty("/rest/api/3/statuscategory", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3FilterFavouriteClass RestApi3Statuscategory { get; set; }

        [JsonProperty("/rest/api/3/statuscategory/{idOrKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3StatuscategoryIdOrKey { get; set; }

        [JsonProperty("/rest/api/3/statuses", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Statuses RestApi3Statuses { get; set; }

        [JsonProperty("/rest/api/3/statuses/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3StatusesSearch { get; set; }

        [JsonProperty("/rest/api/3/task/{taskId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3TaskTaskId RestApi3TaskTaskId { get; set; }

        [JsonProperty("/rest/api/3/task/{taskId}/cancel", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3TaskTaskIdCancel RestApi3TaskTaskIdCancel { get; set; }

        [JsonProperty("/rest/api/3/uiModifications", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UiModifications RestApi3UiModifications { get; set; }

        [JsonProperty("/rest/api/3/uiModifications/{uiModificationId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UiModificationsUiModificationId RestApi3UiModificationsUiModificationId { get; set; }

        [JsonProperty("/rest/api/3/universal_avatar/type/{type}/owner/{entityId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UniversalAvatarTypeTypeOwnerEntityId RestApi3UniversalAvatarTypeTypeOwnerEntityId { get; set; }

        [JsonProperty("/rest/api/3/universal_avatar/type/{type}/owner/{owningObjectId}/avatar/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UniversalAvatarTypeTypeOwnerOwningObjectIdAvatarId RestApi3UniversalAvatarTypeTypeOwnerOwningObjectIdAvatarId { get; set; }

        [JsonProperty("/rest/api/3/universal_avatar/view/type/{type}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_UniversalAvatarViewTypeType RestApi3UniversalAvatarViewTypeType { get; set; }

        [JsonProperty("/rest/api/3/universal_avatar/view/type/{type}/avatar/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UniversalAvatarViewTypeTypeAvatarId RestApi3UniversalAvatarViewTypeTypeAvatarId { get; set; }

        [JsonProperty("/rest/api/3/universal_avatar/view/type/{type}/owner/{entityId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_UniversalAvatarViewTypeType RestApi3UniversalAvatarViewTypeTypeOwnerEntityId { get; set; }

        [JsonProperty("/rest/api/3/user", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3User RestApi3User { get; set; }

        [JsonProperty("/rest/api/3/user/assignable/multiProjectSearch", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserAssignableMultiProjectSearchClass RestApi3UserAssignableMultiProjectSearch { get; set; }

        [JsonProperty("/rest/api/3/user/assignable/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserAssignableSearch RestApi3UserAssignableSearch { get; set; }

        [JsonProperty("/rest/api/3/user/bulk", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3UserBulk { get; set; }

        [JsonProperty("/rest/api/3/user/bulk/migration", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserBulkMigration RestApi3UserBulkMigration { get; set; }

        [JsonProperty("/rest/api/3/user/columns", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserColumns RestApi3UserColumns { get; set; }

        [JsonProperty("/rest/api/3/user/email", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserEmail RestApi3UserEmail { get; set; }

        [JsonProperty("/rest/api/3/user/email/bulk", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserEmailBulk RestApi3UserEmailBulk { get; set; }

        [JsonProperty("/rest/api/3/user/groups", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_User RestApi3UserGroups { get; set; }

        [JsonProperty("/rest/api/3/user/permission/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserPermissionSearchClass RestApi3UserPermissionSearch { get; set; }

        [JsonProperty("/rest/api/3/user/picker", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserPicker RestApi3UserPicker { get; set; }

        [JsonProperty("/rest/api/3/user/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_User RestApi3UserProperties { get; set; }

        [JsonProperty("/rest/api/3/user/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserPropertiesPropertyKey RestApi3UserPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/api/3/user/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserAssignableMultiProjectSearchClass RestApi3UserSearch { get; set; }

        [JsonProperty("/rest/api/3/user/search/query", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_UserSearchQuery RestApi3UserSearchQuery { get; set; }

        [JsonProperty("/rest/api/3/user/search/query/key", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_UserSearchQuery RestApi3UserSearchQueryKey { get; set; }

        [JsonProperty("/rest/api/3/user/viewissue/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3UserPermissionSearchClass RestApi3UserViewissueSearch { get; set; }

        [JsonProperty("/rest/api/3/users", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Users RestApi3Users { get; set; }

        [JsonProperty("/rest/api/3/users/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_Users RestApi3UsersSearch { get; set; }

        [JsonProperty("/rest/api/3/version", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Version RestApi3Version { get; set; }

        [JsonProperty("/rest/api/3/version/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3VersionId RestApi3VersionId { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/mergeto/{moveIssuesTo}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3VersionIdMergetoMoveIssuesTo RestApi3VersionIdMergetoMoveIssuesTo { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/move", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ProjectProjectIdOrKeyRestoreClass RestApi3VersionIdMove { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/relatedIssueCounts", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3VersionIdRelatedIssueCounts { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/relatedwork", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3VersionIdRelatedwork RestApi3VersionIdRelatedwork { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/removeAndSwap", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3VersionIdRemoveAndSwap RestApi3VersionIdRemoveAndSwap { get; set; }

        [JsonProperty("/rest/api/3/version/{id}/unresolvedIssueCount", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3ComponentIdRelatedIssueCountsClass RestApi3VersionIdUnresolvedIssueCount { get; set; }

        [JsonProperty("/rest/api/3/version/{versionId}/relatedwork/{relatedWorkId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3VersionVersionIdRelatedworkRelatedWorkId RestApi3VersionVersionIdRelatedworkRelatedWorkId { get; set; }

        [JsonProperty("/rest/api/3/webhook", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Webhook RestApi3Webhook { get; set; }

        [JsonProperty("/rest/api/3/webhook/failed", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WebhookFailed RestApi3WebhookFailed { get; set; }

        [JsonProperty("/rest/api/3/webhook/refresh", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WebhookRefresh RestApi3WebhookRefresh { get; set; }

        [JsonProperty("/rest/api/3/workflow", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Workflow RestApi3Workflow { get; set; }

        [JsonProperty("/rest/api/3/workflow/rule/config", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowRuleConfig RestApi3WorkflowRuleConfig { get; set; }

        [JsonProperty("/rest/api/3/workflow/rule/config/delete", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowRuleConfigDelete RestApi3WorkflowRuleConfigDelete { get; set; }

        [JsonProperty("/rest/api/3/workflow/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowSearch RestApi3WorkflowSearch { get; set; }

        [JsonProperty("/rest/api/3/workflow/transitions/{transitionId}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowTransitionsTransitionIdProperties RestApi3WorkflowTransitionsTransitionIdProperties { get; set; }

        [JsonProperty("/rest/api/3/workflow/{entityId}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowEntityId RestApi3WorkflowEntityId { get; set; }

        [JsonProperty("/rest/api/3/workflows", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Workflows RestApi3Workflows { get; set; }

        [JsonProperty("/rest/api/3/workflows/capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3JqlAutocompletedataSuggestionsClass RestApi3WorkflowsCapabilities { get; set; }

        [JsonProperty("/rest/api/3/workflows/create", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3WorkflowsCreate { get; set; }

        [JsonProperty("/rest/api/3/workflows/create/validation", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3WorkflowsCreateValidation { get; set; }

        [JsonProperty("/rest/api/3/workflows/update", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowsUpdate RestApi3WorkflowsUpdate { get; set; }

        [JsonProperty("/rest/api/3/workflows/update/validation", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3WorkflowsUpdateValidation { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3Workflowscheme RestApi3Workflowscheme { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/project", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeProject RestApi3WorkflowschemeProject { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/read", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeRead RestApi3WorkflowschemeRead { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/update", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeUpdate RestApi3WorkflowschemeUpdate { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/update/mappings", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3IssueBulkfetchClass RestApi3WorkflowschemeUpdateMappings { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeId RestApi3WorkflowschemeId { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/createdraft", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdCreatedraft RestApi3WorkflowschemeIdCreatedraft { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdDefault RestApi3WorkflowschemeIdDefault { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/draft", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdDraft RestApi3WorkflowschemeIdDraft { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/draft/default", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_WorkflowschemeIdDraft RestApi3WorkflowschemeIdDraftDefault { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/draft/issuetype/{issueType}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3_WorkflowschemeIdDraft RestApi3WorkflowschemeIdDraftIssuetypeIssueType { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/draft/publish", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdDraftPublish RestApi3WorkflowschemeIdDraftPublish { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/draft/workflow", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdDraftWorkflow RestApi3WorkflowschemeIdDraftWorkflow { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/issuetype/{issueType}", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdIssuetypeIssueType RestApi3WorkflowschemeIdIssuetypeIssueType { get; set; }

        [JsonProperty("/rest/api/3/workflowscheme/{id}/workflow", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorkflowschemeIdWorkflow RestApi3WorkflowschemeIdWorkflow { get; set; }

        [JsonProperty("/rest/api/3/worklog/deleted", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3WorklogDeleted { get; set; }

        [JsonProperty("/rest/api/3/worklog/list", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3WorklogList RestApi3WorklogList { get; set; }

        [JsonProperty("/rest/api/3/worklog/updated", NullValueHandling = NullValueHandling.Ignore)]
        public RestApi3AttachmentMetaClass RestApi3WorklogUpdated { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/addons/{addonKey}/properties", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1AddonsAddonKeyProperties RestAtlassianConnect1AddonsAddonKeyProperties { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/addons/{addonKey}/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1AddonsAddonKeyPropertiesPropertyKey RestAtlassianConnect1AddonsAddonKeyPropertiesPropertyKey { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/app/module/dynamic", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1AppModuleDynamic RestAtlassianConnect1AppModuleDynamic { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/migration/field", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1MigrationField RestAtlassianConnect1MigrationField { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/migration/properties/{entityType}", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1MigrationPropertiesEntityType RestAtlassianConnect1MigrationPropertiesEntityType { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/migration/workflow/rule/search", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1MigrationWorkflowRuleSearch RestAtlassianConnect1MigrationWorkflowRuleSearch { get; set; }

        [JsonProperty("/rest/atlassian-connect/1/service-registry", NullValueHandling = NullValueHandling.Ignore)]
        public RestAtlassianConnect1ServiceRegistry RestAtlassianConnect1ServiceRegistry { get; set; }

        [JsonProperty("/rest/forge/1/app/properties/{propertyKey}", NullValueHandling = NullValueHandling.Ignore)]
        public RestForge1AppPropertiesPropertyKey RestForge1AppPropertiesPropertyKey { get; set; }
    }
}