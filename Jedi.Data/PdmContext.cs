using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jedi.Models.Entities.PDM;
using Microsoft.EntityFrameworkCore;

namespace Jedi.Data
{
    public class PdmContext : DbContext
    {
        public PdmContext(DbContextOptions<PdmContext> options) : base(options)
        {

        }

        public virtual DbSet<AdditiveContainedSourceMl> AdditiveContainedSourceMl { get; set; }
        public virtual DbSet<Additives> Additives { get; set; }
        public virtual DbSet<AdditivesContained> AdditivesContained { get; set; }
        public virtual DbSet<AdditivesPossiblyContained> AdditivesPossiblyContained { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Affiliates> Affiliates { get; set; }
        public virtual DbSet<AllergenContainedSourceMl> AllergenContainedSourceMl { get; set; }
        public virtual DbSet<Allergens> Allergens { get; set; }
        public virtual DbSet<AllergensContained> AllergensContained { get; set; }
        public virtual DbSet<AllergensPossiblyContained> AllergensPossiblyContained { get; set; }
        public virtual DbSet<ApplicationBehaviors> ApplicationBehaviors { get; set; }
        public virtual DbSet<AppliesTo> AppliesTo { get; set; }
        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<AuditCorrectiveActionProtclsMl> AuditCorrectiveActionProtclsMl { get; set; }
        public virtual DbSet<AuditCoverPageFields> AuditCoverPageFields { get; set; }
        public virtual DbSet<AuditCoverPageFieldTemplateMl> AuditCoverPageFieldTemplateMl { get; set; }
        public virtual DbSet<AuditCoverPageFieldTemplates> AuditCoverPageFieldTemplates { get; set; }
        public virtual DbSet<AuditCoverPageFieldUiinfo> AuditCoverPageFieldUiinfo { get; set; }
        public virtual DbSet<AuditCriteriaGroupMl> AuditCriteriaGroupMl { get; set; }
        public virtual DbSet<AuditCriterionEvaluations> AuditCriterionEvaluations { get; set; }
        public virtual DbSet<AuditCriterionMl> AuditCriterionMl { get; set; }
        public virtual DbSet<AuditCriterions> AuditCriterions { get; set; }
        public virtual DbSet<AuditCriterionScoringRuleMl> AuditCriterionScoringRuleMl { get; set; }
        public virtual DbSet<AuditCriterionScoringRules> AuditCriterionScoringRules { get; set; }
        public virtual DbSet<AuditCustomAttributeMl> AuditCustomAttributeMl { get; set; }
        public virtual DbSet<AuditCustomAttributes> AuditCustomAttributes { get; set; }
        public virtual DbSet<AuditNumberManager> AuditNumberManager { get; set; }
        public virtual DbSet<AuditOnlineGuidanceSourceMl> AuditOnlineGuidanceSourceMl { get; set; }
        public virtual DbSet<AuditRecords> AuditRecords { get; set; }
        public virtual DbSet<AuditRepeatableSectionTypes> AuditRepeatableSectionTypes { get; set; }
        public virtual DbSet<AuditRepeatableSectionTypesMl> AuditRepeatableSectionTypesMl { get; set; }
        public virtual DbSet<AuditScorecards> AuditScorecards { get; set; }
        public virtual DbSet<AuditScripts> AuditScripts { get; set; }
        public virtual DbSet<AuditScriptTemplates> AuditScriptTemplates { get; set; }
        public virtual DbSet<AuditScriptTemplatesMl> AuditScriptTemplatesMl { get; set; }
        public virtual DbSet<AuditSections> AuditSections { get; set; }
        public virtual DbSet<AuditSectionTemplateMl> AuditSectionTemplateMl { get; set; }
        public virtual DbSet<AuditSectionTemplates> AuditSectionTemplates { get; set; }
        public virtual DbSet<AuditTemplateMl> AuditTemplateMl { get; set; }
        public virtual DbSet<AuditTemplates> AuditTemplates { get; set; }
        public virtual DbSet<AuditTransitionTemplate> AuditTransitionTemplate { get; set; }
        public virtual DbSet<AuditUserNotificationMl> AuditUserNotificationMl { get; set; }
        public virtual DbSet<AuditUserNotifications> AuditUserNotifications { get; set; }
        public virtual DbSet<BofContrivedChildren> BofContrivedChildren { get; set; }
        public virtual DbSet<BofContrivedEntities> BofContrivedEntities { get; set; }
        public virtual DbSet<BofContrivedEntitiesWithAttr> BofContrivedEntitiesWithAttr { get; set; }
        public virtual DbSet<BofSimpleNameValueAttributes> BofSimpleNameValueAttributes { get; set; }
        public virtual DbSet<BomItem> BomItem { get; set; }
        public virtual DbSet<BreakdownReconEquivTargets> BreakdownReconEquivTargets { get; set; }
        public virtual DbSet<CacsapprovedUsageAttribute> CacsapprovedUsageAttribute { get; set; }
        public virtual DbSet<CacsapprovedUsageAttributeMl> CacsapprovedUsageAttributeMl { get; set; }
        public virtual DbSet<Cacsattribute> Cacsattribute { get; set; }
        public virtual DbSet<CacsattributeContainer> CacsattributeContainer { get; set; }
        public virtual DbSet<CacsattributeMl> CacsattributeMl { get; set; }
        public virtual DbSet<CacsavailableIn> CacsavailableIn { get; set; }
        public virtual DbSet<CacsavailableInMl> CacsavailableInMl { get; set; }
        public virtual DbSet<CacscomplianceConstraint> CacscomplianceConstraint { get; set; }
        public virtual DbSet<CacsconstraintItem> CacsconstraintItem { get; set; }
        public virtual DbSet<CacsextAttributeConstraint> CacsextAttributeConstraint { get; set; }
        public virtual DbSet<CacsnutrientConstraint> CacsnutrientConstraint { get; set; }
        public virtual DbSet<Cacsscreen> Cacsscreen { get; set; }
        public virtual DbSet<CacsusageApprovalConstraint> CacsusageApprovalConstraint { get; set; }
        public virtual DbSet<CcmsImportSubmission> CcmsImportSubmission { get; set; }
        public virtual DbSet<CcmsImportType> CcmsImportType { get; set; }
        public virtual DbSet<CcmsStatuses> CcmsStatuses { get; set; }
        public virtual DbSet<CcmsStatusTextValues> CcmsStatusTextValues { get; set; }
        public virtual DbSet<CcmsTranslationItemValStatuses> CcmsTranslationItemValStatuses { get; set; }
        public virtual DbSet<CcmsWorksetItemRejectComments> CcmsWorksetItemRejectComments { get; set; }
        public virtual DbSet<CcmsWorksetItems> CcmsWorksetItems { get; set; }
        public virtual DbSet<CcmsWorksets> CcmsWorksets { get; set; }
        public virtual DbSet<CodeAgents> CodeAgents { get; set; }
        public virtual DbSet<CollapsibleContentStates> CollapsibleContentStates { get; set; }
        public virtual DbSet<ComCurrencyConvTimeFrameMl> ComCurrencyConvTimeFrameMl { get; set; }
        public virtual DbSet<ComCurrencyConvTimeFrames> ComCurrencyConvTimeFrames { get; set; }
        public virtual DbSet<ComExtendedAttributeQualityMl> ComExtendedAttributeQualityMl { get; set; }
        public virtual DbSet<ComExtendedAttrQualityList> ComExtendedAttrQualityList { get; set; }
        public virtual DbSet<ComExtendedAttrStatusMl> ComExtendedAttrStatusMl { get; set; }
        public virtual DbSet<ComLwfactionTemplates> ComLwfactionTemplates { get; set; }
        public virtual DbSet<ComLwfactivityTemplates> ComLwfactivityTemplates { get; set; }
        public virtual DbSet<ComLwfconfigurations> ComLwfconfigurations { get; set; }
        public virtual DbSet<ComLwfextBehaviorTemplateMl> ComLwfextBehaviorTemplateMl { get; set; }
        public virtual DbSet<ComLwfextendedBehaviorTemplate> ComLwfextendedBehaviorTemplate { get; set; }
        public virtual DbSet<ComLwfgaurdConditionTemplates> ComLwfgaurdConditionTemplates { get; set; }
        public virtual DbSet<ComLwfnameValueAttributes> ComLwfnameValueAttributes { get; set; }
        public virtual DbSet<ComLwfnotifications> ComLwfnotifications { get; set; }
        public virtual DbSet<ComLwfprocessInstance> ComLwfprocessInstance { get; set; }
        public virtual DbSet<ComLwfprocessTemplateEditor> ComLwfprocessTemplateEditor { get; set; }
        public virtual DbSet<ComLwfprocessTemplateMl> ComLwfprocessTemplateMl { get; set; }
        public virtual DbSet<ComLwfprocessTemplates> ComLwfprocessTemplates { get; set; }
        public virtual DbSet<ComLwfprocessTemplateTypes> ComLwfprocessTemplateTypes { get; set; }
        public virtual DbSet<ComLwfsectionControl> ComLwfsectionControl { get; set; }
        public virtual DbSet<ComLwftransitionTemplates> ComLwftransitionTemplates { get; set; }
        public virtual DbSet<ComLwfuiconfiguration> ComLwfuiconfiguration { get; set; }
        public virtual DbSet<CommonActivitySpecLink> CommonActivitySpecLink { get; set; }
        public virtual DbSet<CommonAttributeRangeItem> CommonAttributeRangeItem { get; set; }
        public virtual DbSet<CommonBreakdowns> CommonBreakdowns { get; set; }
        public virtual DbSet<CommonBunamespace> CommonBunamespace { get; set; }
        public virtual DbSet<CommonBusinessUnit> CommonBusinessUnit { get; set; }
        public virtual DbSet<CommonBusinessUnitName> CommonBusinessUnitName { get; set; }
        public virtual DbSet<CommonCacheFlushEvent> CommonCacheFlushEvent { get; set; }
        public virtual DbSet<CommonCacheFlushRequest> CommonCacheFlushRequest { get; set; }
        public virtual DbSet<CommonConfigurationBundle> CommonConfigurationBundle { get; set; }
        public virtual DbSet<CommonConfigurationEnvironment> CommonConfigurationEnvironment { get; set; }
        public virtual DbSet<CommonConfigurationName> CommonConfigurationName { get; set; }
        public virtual DbSet<CommonConfigurationNamespace> CommonConfigurationNamespace { get; set; }
        public virtual DbSet<CommonConfigurationRversion> CommonConfigurationRversion { get; set; }
        public virtual DbSet<CommonConfigurationType> CommonConfigurationType { get; set; }
        public virtual DbSet<CommonConfigurationValue> CommonConfigurationValue { get; set; }
        public virtual DbSet<CommonCurrencies> CommonCurrencies { get; set; }
        public virtual DbSet<CommonCurrenciesMl> CommonCurrenciesMl { get; set; }
        public virtual DbSet<CommonCurrencyConversionRates> CommonCurrencyConversionRates { get; set; }
        public virtual DbSet<CommonDataGroupMapping> CommonDataGroupMapping { get; set; }
        public virtual DbSet<CommonDataMapException> CommonDataMapException { get; set; }
        public virtual DbSet<CommonEacolumnTemplate> CommonEacolumnTemplate { get; set; }
        public virtual DbSet<CommonEarowTemplate> CommonEarowTemplate { get; set; }
        public virtual DbSet<CommonEasectionCellTemplate> CommonEasectionCellTemplate { get; set; }
        public virtual DbSet<CommonEasectionTemplate> CommonEasectionTemplate { get; set; }
        public virtual DbSet<CommonExtendedAttribOptionMl> CommonExtendedAttribOptionMl { get; set; }
        public virtual DbSet<CommonExtendedAttributeMl> CommonExtendedAttributeMl { get; set; }
        public virtual DbSet<CommonExtendedAttributeOptions> CommonExtendedAttributeOptions { get; set; }
        public virtual DbSet<CommonExtendedAttributeQuality> CommonExtendedAttributeQuality { get; set; }
        public virtual DbSet<CommonExtendedAttributeStatus> CommonExtendedAttributeStatus { get; set; }
        public virtual DbSet<CommonExtendedAttributeType> CommonExtendedAttributeType { get; set; }
        public virtual DbSet<CommonExtendedAttributeTypeMl> CommonExtendedAttributeTypeMl { get; set; }
        public virtual DbSet<CommonExternalIdlookup> CommonExternalIdlookup { get; set; }
        public virtual DbSet<CommonFunctionalUnits> CommonFunctionalUnits { get; set; }
        public virtual DbSet<CommonLifecycleEventLog> CommonLifecycleEventLog { get; set; }
        public virtual DbSet<CommonLinearWorkflowActivities> CommonLinearWorkflowActivities { get; set; }
        public virtual DbSet<CommonLinearWorkflowProcesses> CommonLinearWorkflowProcesses { get; set; }
        public virtual DbSet<CommonLinearWorkflowStatuses> CommonLinearWorkflowStatuses { get; set; }
        public virtual DbSet<CommonLookups> CommonLookups { get; set; }
        public virtual DbSet<CommonLookupServiceManagers> CommonLookupServiceManagers { get; set; }
        public virtual DbSet<CommonLwfprocessResolutionSet> CommonLwfprocessResolutionSet { get; set; }
        public virtual DbSet<CommonLwfresSetParticipants> CommonLwfresSetParticipants { get; set; }
        public virtual DbSet<CommonLwftransitions> CommonLwftransitions { get; set; }
        public virtual DbSet<CommonManagedDocument> CommonManagedDocument { get; set; }
        public virtual DbSet<CommonMultiPartAttachment> CommonMultiPartAttachment { get; set; }
        public virtual DbSet<CommonObjectMrulog> CommonObjectMrulog { get; set; }
        public virtual DbSet<CommonOwnedXdocument> CommonOwnedXdocument { get; set; }
        public virtual DbSet<CommonReplicationHistory> CommonReplicationHistory { get; set; }
        public virtual DbSet<CommonSegment> CommonSegment { get; set; }
        public virtual DbSet<CommonSegmentName> CommonSegmentName { get; set; }
        public virtual DbSet<CommonServiceCache> CommonServiceCache { get; set; }
        public virtual DbSet<CommonServiceCacheGroup> CommonServiceCacheGroup { get; set; }
        public virtual DbSet<CommonSmiltaxonomyNode> CommonSmiltaxonomyNode { get; set; }
        public virtual DbSet<CommonSmiltaxonomyNodeMl> CommonSmiltaxonomyNodeMl { get; set; }
        public virtual DbSet<CommonSubstituteLookups> CommonSubstituteLookups { get; set; }
        public virtual DbSet<CommonSupportingXdocuments> CommonSupportingXdocuments { get; set; }
        public virtual DbSet<CommonTaxonomyBase> CommonTaxonomyBase { get; set; }
        public virtual DbSet<CommonTaxonomyNamespace> CommonTaxonomyNamespace { get; set; }
        public virtual DbSet<CommonTextRepository> CommonTextRepository { get; set; }
        public virtual DbSet<CommonTransactionId> CommonTransactionId { get; set; }
        public virtual DbSet<CommonTranslationCaches> CommonTranslationCaches { get; set; }
        public virtual DbSet<CommonTranslationItems> CommonTranslationItems { get; set; }
        public virtual DbSet<CommonTranslationItemValues> CommonTranslationItemValues { get; set; }
        public virtual DbSet<CommonWorkflowAuditHistory> CommonWorkflowAuditHistory { get; set; }
        public virtual DbSet<CommonWorkflowStatus> CommonWorkflowStatus { get; set; }
        public virtual DbSet<CommonXlaextensionCache> CommonXlaextensionCache { get; set; }
        public virtual DbSet<CommonXlaextensionCacheItem> CommonXlaextensionCacheItem { get; set; }
        public virtual DbSet<ComplianceItem> ComplianceItem { get; set; }
        public virtual DbSet<ComplianceItemContainedSource> ComplianceItemContainedSource { get; set; }
        public virtual DbSet<ComplianceItemContainer> ComplianceItemContainer { get; set; }
        public virtual DbSet<CompliesWith> CompliesWith { get; set; }
        public virtual DbSet<ComponentFunction> ComponentFunction { get; set; }
        public virtual DbSet<ComStandardNutrientProperties> ComStandardNutrientProperties { get; set; }
        public virtual DbSet<ComStdNutrientPropertiesMl> ComStdNutrientPropertiesMl { get; set; }
        public virtual DbSet<Constraints> Constraints { get; set; }
        public virtual DbSet<CostItems> CostItems { get; set; }
        public virtual DbSet<CostMessages> CostMessages { get; set; }
        public virtual DbSet<CostOptimizationConstraints> CostOptimizationConstraints { get; set; }
        public virtual DbSet<CostOptimizationObjectives> CostOptimizationObjectives { get; set; }
        public virtual DbSet<Costs> Costs { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CpFilters> CpFilters { get; set; }
        public virtual DbSet<CpPortals> CpPortals { get; set; }
        public virtual DbSet<CpProfiles> CpProfiles { get; set; }
        public virtual DbSet<CpViews> CpViews { get; set; }
        public virtual DbSet<CssAuditHistory> CssAuditHistory { get; set; }
        public virtual DbSet<CsseanpackageTypes> CsseanpackageTypes { get; set; }
        public virtual DbSet<CsseanpackagingMaterialTypes> CsseanpackagingMaterialTypes { get; set; }
        public virtual DbSet<CsseanproductGroup> CsseanproductGroup { get; set; }
        public virtual DbSet<Cssgpcstatus> Cssgpcstatus { get; set; }
        public virtual DbSet<CssInfoProvider> CssInfoProvider { get; set; }
        public virtual DbSet<CssManufacturer> CssManufacturer { get; set; }
        public virtual DbSet<CssPermissionTemplateItems> CssPermissionTemplateItems { get; set; }
        public virtual DbSet<CssPermissionTemplates> CssPermissionTemplates { get; set; }
        public virtual DbSet<CssPermissionTemplItemColls> CssPermissionTemplItemColls { get; set; }
        public virtual DbSet<CssPublicationNamespace> CssPublicationNamespace { get; set; }
        public virtual DbSet<CssRetailer> CssRetailer { get; set; }
        public virtual DbSet<CssTargetMarket> CssTargetMarket { get; set; }
        public virtual DbSet<CssTipOwners> CssTipOwners { get; set; }
        public virtual DbSet<CssTradeItemPublication> CssTradeItemPublication { get; set; }
        public virtual DbSet<CssTradingPartnerNode> CssTradingPartnerNode { get; set; }
        public virtual DbSet<CssTradingPartnerNodeMl> CssTradingPartnerNodeMl { get; set; }
        public virtual DbSet<CssTransaction> CssTransaction { get; set; }
        public virtual DbSet<CssWfguardConditionTemplates> CssWfguardConditionTemplates { get; set; }
        public virtual DbSet<CssWorkflowActionTemplates> CssWorkflowActionTemplates { get; set; }
        public virtual DbSet<CssWorkflowActivityTemplates> CssWorkflowActivityTemplates { get; set; }
        public virtual DbSet<CssWorkflowGroupMapTaxonomy> CssWorkflowGroupMapTaxonomy { get; set; }
        public virtual DbSet<CssWorkflowNameValueAttributes> CssWorkflowNameValueAttributes { get; set; }
        public virtual DbSet<CssWorkflowProcessTemplates> CssWorkflowProcessTemplates { get; set; }
        public virtual DbSet<CssWorkflowStatuses> CssWorkflowStatuses { get; set; }
        public virtual DbSet<CssWorkflowTransitionTemplates> CssWorkflowTransitionTemplates { get; set; }
        public virtual DbSet<CustomLookup> CustomLookup { get; set; }
        public virtual DbSet<CustomNotifications> CustomNotifications { get; set; }
        public virtual DbSet<DataAdminAuditHistory> DataAdminAuditHistory { get; set; }
        public virtual DbSet<DataAdminToolkitVersionHist> DataAdminToolkitVersionHist { get; set; }
        public virtual DbSet<DataExchangeVersionTracker> DataExchangeVersionTracker { get; set; }
        public virtual DbSet<DataGroup> DataGroup { get; set; }
        public virtual DbSet<DenormHdConfig> DenormHdConfig { get; set; }
        public virtual DbSet<DenormHdHierarchyGsm> DenormHdHierarchyGsm { get; set; }
        public virtual DbSet<DenormHdHierarchyScrm> DenormHdHierarchyScrm { get; set; }
        public virtual DbSet<DenormHdRelationshipCtx> DenormHdRelationshipCtx { get; set; }
        public virtual DbSet<DenormHdRelationshipCtxMl> DenormHdRelationshipCtxMl { get; set; }
        public virtual DbSet<DenormHdRequest> DenormHdRequest { get; set; }
        public virtual DbSet<Densities> Densities { get; set; }
        public virtual DbSet<DrlApplicationDrlReference> DrlApplicationDrlReference { get; set; }
        public virtual DbSet<DrlAttachment> DrlAttachment { get; set; }
        public virtual DbSet<DrlAttachmentReference> DrlAttachmentReference { get; set; }
        public virtual DbSet<DrlDocument> DrlDocument { get; set; }
        public virtual DbSet<DrlDocumentReference> DrlDocumentReference { get; set; }
        public virtual DbSet<DrlDocumentReferencesContainer> DrlDocumentReferencesContainer { get; set; }
        public virtual DbSet<DrlDocumentTitleMl> DrlDocumentTitleMl { get; set; }
        public virtual DbSet<DwbAdditiveContainer> DwbAdditiveContainer { get; set; }
        public virtual DbSet<DwbAllergenContainer> DwbAllergenContainer { get; set; }
        public virtual DbSet<DwbBreakdown> DwbBreakdown { get; set; }
        public virtual DbSet<DwbBreakdownSummary> DwbBreakdownSummary { get; set; }
        public virtual DbSet<DwbExtendedAttribute> DwbExtendedAttribute { get; set; }
        public virtual DbSet<DwbFormulationItems> DwbFormulationItems { get; set; }
        public virtual DbSet<DwbIntoleranceContainer> DwbIntoleranceContainer { get; set; }
        public virtual DbSet<DwbLioadjustments> DwbLioadjustments { get; set; }
        public virtual DbSet<DwbLiocomponentReferences> DwbLiocomponentReferences { get; set; }
        public virtual DbSet<DwbLiogroups> DwbLiogroups { get; set; }
        public virtual DbSet<DwbLioitems> DwbLioitems { get; set; }
        public virtual DbSet<DwbNutrient> DwbNutrient { get; set; }
        public virtual DbSet<DwbOptimizationConstraint> DwbOptimizationConstraint { get; set; }
        public virtual DbSet<DwbPackageConfigDo> DwbPackageConfigDo { get; set; }
        public virtual DbSet<DwbPackagingMaterial> DwbPackagingMaterial { get; set; }
        public virtual DbSet<DwbPossiblyCntnedAdditiveCntnr> DwbPossiblyCntnedAdditiveCntnr { get; set; }
        public virtual DbSet<DwbPossiblyCntnedAllergenCntnr> DwbPossiblyCntnedAllergenCntnr { get; set; }
        public virtual DbSet<DwbPossiblyCntnedIntolCntnr> DwbPossiblyCntnedIntolCntnr { get; set; }
        public virtual DbSet<DwbProfile> DwbProfile { get; set; }
        public virtual DbSet<DwbSpecAttributes> DwbSpecAttributes { get; set; }
        public virtual DbSet<DwbspecificationRoots> DwbspecificationRoots { get; set; }
        public virtual DbSet<DwbSpecifications> DwbSpecifications { get; set; }
        public virtual DbSet<DwbSpecificationStep> DwbSpecificationStep { get; set; }
        public virtual DbSet<DwbspecStatus> DwbspecStatus { get; set; }
        public virtual DbSet<DwbspecStatusMl> DwbspecStatusMl { get; set; }
        public virtual DbSet<DwbSpecSubstitute> DwbSpecSubstitute { get; set; }
        public virtual DbSet<EanuomEquivalent> EanuomEquivalent { get; set; }
        public virtual DbSet<EatypeAllowedTargetSpecsMap> EatypeAllowedTargetSpecsMap { get; set; }
        public virtual DbSet<EqAdditive> EqAdditive { get; set; }
        public virtual DbSet<EqAllergen> EqAllergen { get; set; }
        public virtual DbSet<EqbreakdownContainer> EqbreakdownContainer { get; set; }
        public virtual DbSet<EqCompliesWith> EqCompliesWith { get; set; }
        public virtual DbSet<EqDrlDocsDo> EqDrlDocsDo { get; set; }
        public virtual DbSet<EqIntolerances> EqIntolerances { get; set; }
        public virtual DbSet<EqItems> EqItems { get; set; }
        public virtual DbSet<EqMarking> EqMarking { get; set; }
        public virtual DbSet<EqMarkingMl> EqMarkingMl { get; set; }
        public virtual DbSet<EqMatBreakdown> EqMatBreakdown { get; set; }
        public virtual DbSet<EqMaterialQuestionnaire> EqMaterialQuestionnaire { get; set; }
        public virtual DbSet<EqModel> EqModel { get; set; }
        public virtual DbSet<EqModelSection> EqModelSection { get; set; }
        public virtual DbSet<EqNutrientItems> EqNutrientItems { get; set; }
        public virtual DbSet<EqPackagingQuestionnaire> EqPackagingQuestionnaire { get; set; }
        public virtual DbSet<EqpackagingWastes> EqpackagingWastes { get; set; }
        public virtual DbSet<EqPrintedPkgingQuestionnaire> EqPrintedPkgingQuestionnaire { get; set; }
        public virtual DbSet<EqProductQuestionnaire> EqProductQuestionnaire { get; set; }
        public virtual DbSet<EqReassignEvents> EqReassignEvents { get; set; }
        public virtual DbSet<EqRequest> EqRequest { get; set; }
        public virtual DbSet<EqrequestTemplates> EqrequestTemplates { get; set; }
        public virtual DbSet<EqSourcingAttribute> EqSourcingAttribute { get; set; }
        public virtual DbSet<EqSupportingDocs> EqSupportingDocs { get; set; }
        public virtual DbSet<EqTradeQuestionnaire> EqTradeQuestionnaire { get; set; }
        public virtual DbSet<EqtsearchCriteria> EqtsearchCriteria { get; set; }
        public virtual DbSet<EqtsearchEntry> EqtsearchEntry { get; set; }
        public virtual DbSet<EquipmentInfoMl> EquipmentInfoMl { get; set; }
        public virtual DbSet<ExtendedAttributeOptConstraint> ExtendedAttributeOptConstraint { get; set; }
        public virtual DbSet<ExtendedAttributeOptObjective> ExtendedAttributeOptObjective { get; set; }
        public virtual DbSet<ExtendedAttributesContainer> ExtendedAttributesContainer { get; set; }
        public virtual DbSet<ExtendedAttributeTheoRollBeh> ExtendedAttributeTheoRollBeh { get; set; }
        public virtual DbSet<FclfoodGroup> FclfoodGroup { get; set; }
        public virtual DbSet<FclfoodGroupMl> FclfoodGroupMl { get; set; }
        public virtual DbSet<FclfoodItem> FclfoodItem { get; set; }
        public virtual DbSet<FclfoodItemMl> FclfoodItemMl { get; set; }
        public virtual DbSet<FclfoodNutrientValue> FclfoodNutrientValue { get; set; }
        public virtual DbSet<Fclnutrient> Fclnutrient { get; set; }
        public virtual DbSet<FclnutrientMl> FclnutrientMl { get; set; }
        public virtual DbSet<Fclsource> Fclsource { get; set; }
        public virtual DbSet<FicliodisclosureNameMl> FicliodisclosureNameMl { get; set; }
        public virtual DbSet<FicliodisclosureNotesMl> FicliodisclosureNotesMl { get; set; }
        public virtual DbSet<Ficliodisclosures> Ficliodisclosures { get; set; }
        public virtual DbSet<FicTermAliases> FicTermAliases { get; set; }
        public virtual DbSet<FicTermAliasNamesMl> FicTermAliasNamesMl { get; set; }
        public virtual DbSet<FicTermAliasNotesMl> FicTermAliasNotesMl { get; set; }
        public virtual DbSet<FicTerms> FicTerms { get; set; }
        public virtual DbSet<FinishedPackagingSpec> FinishedPackagingSpec { get; set; }
        public virtual DbSet<FinishedProductBrand> FinishedProductBrand { get; set; }
        public virtual DbSet<FinishedProductSpec> FinishedProductSpec { get; set; }
        public virtual DbSet<FoodServiceAltMenuItemBuild> FoodServiceAltMenuItemBuild { get; set; }
        public virtual DbSet<FoodServiceDesignAttribute> FoodServiceDesignAttribute { get; set; }
        public virtual DbSet<FoodServiceFormulations> FoodServiceFormulations { get; set; }
        public virtual DbSet<FoodServiceGlobalRegionalStd> FoodServiceGlobalRegionalStd { get; set; }
        public virtual DbSet<FoodServiceMenuItem> FoodServiceMenuItem { get; set; }
        public virtual DbSet<FoodServiceMenuItemBuild> FoodServiceMenuItemBuild { get; set; }
        public virtual DbSet<FoodServiceMenuItemClass> FoodServiceMenuItemClass { get; set; }
        public virtual DbSet<FoodServiceProduct> FoodServiceProduct { get; set; }
        public virtual DbSet<FoodServiceProductAttribute> FoodServiceProductAttribute { get; set; }
        public virtual DbSet<FoodServiceStandardType> FoodServiceStandardType { get; set; }
        public virtual DbSet<FoodServiceStandardTypeMl> FoodServiceStandardTypeMl { get; set; }
        public virtual DbSet<FormSpecAttributes> FormSpecAttributes { get; set; }
        public virtual DbSet<FormulationClassificationMl> FormulationClassificationMl { get; set; }
        public virtual DbSet<FormulationClassifications> FormulationClassifications { get; set; }
        public virtual DbSet<FormulationCompostionMappings> FormulationCompostionMappings { get; set; }
        public virtual DbSet<FormulationInputRatio> FormulationInputRatio { get; set; }
        public virtual DbSet<FormulationOutputOverrides> FormulationOutputOverrides { get; set; }
        public virtual DbSet<FormulationOutputSettings> FormulationOutputSettings { get; set; }
        public virtual DbSet<FormulationSpecification> FormulationSpecification { get; set; }
        public virtual DbSet<FormulationTheoreticalRollup> FormulationTheoreticalRollup { get; set; }
        public virtual DbSet<GroupChangeRequestAction> GroupChangeRequestAction { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupsMl> GroupsMl { get; set; }
        public virtual DbSet<GsmApprovedUsage> GsmApprovedUsage { get; set; }
        public virtual DbSet<GsmAssociatedSpec> GsmAssociatedSpec { get; set; }
        public virtual DbSet<GsmAssociationType> GsmAssociationType { get; set; }
        public virtual DbSet<GsmAssociationTypeMl> GsmAssociationTypeMl { get; set; }
        public virtual DbSet<GsmAttributeRange> GsmAttributeRange { get; set; }
        public virtual DbSet<GsmAttributeRangeGroupMl> GsmAttributeRangeGroupMl { get; set; }
        public virtual DbSet<GsmAttributeRangeItemMl> GsmAttributeRangeItemMl { get; set; }
        public virtual DbSet<GsmBaseMaterialSubstitute> GsmBaseMaterialSubstitute { get; set; }
        public virtual DbSet<GsmBaseSpecAttributesDo> GsmBaseSpecAttributesDo { get; set; }
        public virtual DbSet<GsmBaseTradeSpec> GsmBaseTradeSpec { get; set; }
        public virtual DbSet<GsmBrandInformation> GsmBrandInformation { get; set; }
        public virtual DbSet<GsmBrandInformationFreeText> GsmBrandInformationFreeText { get; set; }
        public virtual DbSet<GsmCombinedPackagingAlternates> GsmCombinedPackagingAlternates { get; set; }
        public virtual DbSet<GsmCombinedPrintPkgingAlts> GsmCombinedPrintPkgingAlts { get; set; }
        public virtual DbSet<GsmCupackagingAttributes> GsmCupackagingAttributes { get; set; }
        public virtual DbSet<GsmCupackagingFreeText> GsmCupackagingFreeText { get; set; }
        public virtual DbSet<GsmEanspecialConditions> GsmEanspecialConditions { get; set; }
        public virtual DbSet<GsmEquipmentSpecification> GsmEquipmentSpecification { get; set; }
        public virtual DbSet<GsmExtendedAttributeGroupMl> GsmExtendedAttributeGroupMl { get; set; }
        public virtual DbSet<GsmFormulaOutputType> GsmFormulaOutputType { get; set; }
        public virtual DbSet<GsmFormulaOutputTypeMml> GsmFormulaOutputTypeMml { get; set; }
        public virtual DbSet<GsmFormulationInputs> GsmFormulationInputs { get; set; }
        public virtual DbSet<GsmFormulationMaterials> GsmFormulationMaterials { get; set; }
        public virtual DbSet<GsmFormulationOutput> GsmFormulationOutput { get; set; }
        public virtual DbSet<GsmFormulationSpecAttributes> GsmFormulationSpecAttributes { get; set; }
        public virtual DbSet<GsmFormulationSteps> GsmFormulationSteps { get; set; }
        public virtual DbSet<GsmFormulationSubMaterial> GsmFormulationSubMaterial { get; set; }
        public virtual DbSet<GsmFormulationType> GsmFormulationType { get; set; }
        public virtual DbSet<GsmFormulationTypeMml> GsmFormulationTypeMml { get; set; }
        public virtual DbSet<GsmFreeTextComment> GsmFreeTextComment { get; set; }
        public virtual DbSet<GsmFsisapplication> GsmFsisapplication { get; set; }
        public virtual DbSet<GsmLabelClaim> GsmLabelClaim { get; set; }
        public virtual DbSet<GsmLabelCompositionProfile> GsmLabelCompositionProfile { get; set; }
        public virtual DbSet<GsmLabelCompProfileItems> GsmLabelCompProfileItems { get; set; }
        public virtual DbSet<GsmLabelOwner> GsmLabelOwner { get; set; }
        public virtual DbSet<GsmLanguages> GsmLanguages { get; set; }
        public virtual DbSet<GsmMatBreakdownDescFreeText> GsmMatBreakdownDescFreeText { get; set; }
        public virtual DbSet<GsmMatBreakdownExtDescFreeText> GsmMatBreakdownExtDescFreeText { get; set; }
        public virtual DbSet<GsmMaterialOriginalItem> GsmMaterialOriginalItem { get; set; }
        public virtual DbSet<GsmMaterialSubstitute> GsmMaterialSubstitute { get; set; }
        public virtual DbSet<GsmMaterialSubstituteItem> GsmMaterialSubstituteItem { get; set; }
        public virtual DbSet<GsmMaterialType> GsmMaterialType { get; set; }
        public virtual DbSet<GsmMaterialTypeMml> GsmMaterialTypeMml { get; set; }
        public virtual DbSet<GsmNutrientComposite> GsmNutrientComposite { get; set; }
        public virtual DbSet<GsmNutrientCompositeItem> GsmNutrientCompositeItem { get; set; }
        public virtual DbSet<GsmNutrientExtendedAttribute> GsmNutrientExtendedAttribute { get; set; }
        public virtual DbSet<GsmNutrientItemNotesFreeText> GsmNutrientItemNotesFreeText { get; set; }
        public virtual DbSet<GsmNutrientProfile> GsmNutrientProfile { get; set; }
        public virtual DbSet<GsmNutrientProfileContainer> GsmNutrientProfileContainer { get; set; }
        public virtual DbSet<GsmNutritionalPanelItem> GsmNutritionalPanelItem { get; set; }
        public virtual DbSet<GsmNutritionalPanelItemMl> GsmNutritionalPanelItemMl { get; set; }
        public virtual DbSet<GsmOutputApproximateYield> GsmOutputApproximateYield { get; set; }
        public virtual DbSet<GsmPackageType> GsmPackageType { get; set; }
        public virtual DbSet<GsmPackageTypeMl> GsmPackageTypeMl { get; set; }
        public virtual DbSet<GsmPackageTypeMml> GsmPackageTypeMml { get; set; }
        public virtual DbSet<GsmPackagingAttributeCoding> GsmPackagingAttributeCoding { get; set; }
        public virtual DbSet<GsmPackagingAttributeCu> GsmPackagingAttributeCu { get; set; }
        public virtual DbSet<GsmPackagingAttributeTu> GsmPackagingAttributeTu { get; set; }
        public virtual DbSet<GsmPackagingLevel> GsmPackagingLevel { get; set; }
        public virtual DbSet<GsmPackagingMaterial> GsmPackagingMaterial { get; set; }
        public virtual DbSet<GsmPalletConfig> GsmPalletConfig { get; set; }
        public virtual DbSet<GsmPalletType> GsmPalletType { get; set; }
        public virtual DbSet<GsmpermissionTemplateItems> GsmpermissionTemplateItems { get; set; }
        public virtual DbSet<GsmpermissionTemplates> GsmpermissionTemplates { get; set; }
        public virtual DbSet<GsmpermissionTemplItemColls> GsmpermissionTemplItemColls { get; set; }
        public virtual DbSet<GsmPrintModelRows> GsmPrintModelRows { get; set; }
        public virtual DbSet<GsmProcessSpecPrintModel> GsmProcessSpecPrintModel { get; set; }
        public virtual DbSet<GsmProductClassification> GsmProductClassification { get; set; }
        public virtual DbSet<GsmProductFactSheet> GsmProductFactSheet { get; set; }
        public virtual DbSet<GsmProductIdentification> GsmProductIdentification { get; set; }
        public virtual DbSet<GsmRelatedPackaging> GsmRelatedPackaging { get; set; }
        public virtual DbSet<GsmRelatedPackagingAlternate> GsmRelatedPackagingAlternate { get; set; }
        public virtual DbSet<GsmRelatedPackingConfig> GsmRelatedPackingConfig { get; set; }
        public virtual DbSet<GsmServingLabelFreeText> GsmServingLabelFreeText { get; set; }
        public virtual DbSet<GsmShelfLives> GsmShelfLives { get; set; }
        public virtual DbSet<GsmShortNameMl> GsmShortNameMl { get; set; }
        public virtual DbSet<GsmSignatureDocOwners> GsmSignatureDocOwners { get; set; }
        public virtual DbSet<GsmSignatureDocs> GsmSignatureDocs { get; set; }
        public virtual DbSet<GsmSignatureDocWfauditHistory> GsmSignatureDocWfauditHistory { get; set; }
        public virtual DbSet<GsmSpecOwners> GsmSpecOwners { get; set; }
        public virtual DbSet<GsmStepCalcTypeLookupItems> GsmStepCalcTypeLookupItems { get; set; }
        public virtual DbSet<GsmStepCalcTypeLookupItemsMl> GsmStepCalcTypeLookupItemsMl { get; set; }
        public virtual DbSet<GsmStorageReqrmtsTradeSpecs> GsmStorageReqrmtsTradeSpecs { get; set; }
        public virtual DbSet<GsmsuccessionRequest> GsmsuccessionRequest { get; set; }
        public virtual DbSet<GsmSyncWithItemMldo> GsmSyncWithItemMldo { get; set; }
        public virtual DbSet<GsmSyncWithItems> GsmSyncWithItems { get; set; }
        public virtual DbSet<GsmTareWeight> GsmTareWeight { get; set; }
        public virtual DbSet<GsmTaxType> GsmTaxType { get; set; }
        public virtual DbSet<GsmTemperatureRange> GsmTemperatureRange { get; set; }
        public virtual DbSet<GsmtempSigAuthorities> GsmtempSigAuthorities { get; set; }
        public virtual DbSet<GsmTestMethod> GsmTestMethod { get; set; }
        public virtual DbSet<GsmTestMethodMl> GsmTestMethodMl { get; set; }
        public virtual DbSet<GsmTheoreticalYield> GsmTheoreticalYield { get; set; }
        public virtual DbSet<GsmTpselectionFrequencyJoin> GsmTpselectionFrequencyJoin { get; set; }
        public virtual DbSet<GsmTradedUnit> GsmTradedUnit { get; set; }
        public virtual DbSet<GsmTradedUnitProductType> GsmTradedUnitProductType { get; set; }
        public virtual DbSet<GsmTradedUnitProductTypeMl> GsmTradedUnitProductTypeMl { get; set; }
        public virtual DbSet<GsmTradeMaterialSpecRelation> GsmTradeMaterialSpecRelation { get; set; }
        public virtual DbSet<GsmTradeParentChildJoin> GsmTradeParentChildJoin { get; set; }
        public virtual DbSet<GsmTradeType> GsmTradeType { get; set; }
        public virtual DbSet<GsmTradeTypeMml> GsmTradeTypeMml { get; set; }
        public virtual DbSet<GsmTradingCompany> GsmTradingCompany { get; set; }
        public virtual DbSet<GsmUdexclassification> GsmUdexclassification { get; set; }
        public virtual DbSet<GsmVarietyTitleFreeText> GsmVarietyTitleFreeText { get; set; }
        public virtual DbSet<GsmWfgaurdConditionTemplates> GsmWfgaurdConditionTemplates { get; set; }
        public virtual DbSet<GsmWorkflowActionTemplates> GsmWorkflowActionTemplates { get; set; }
        public virtual DbSet<GsmWorkflowActivityTemplates> GsmWorkflowActivityTemplates { get; set; }
        public virtual DbSet<GsmWorkflowGroupMapTaxonomy> GsmWorkflowGroupMapTaxonomy { get; set; }
        public virtual DbSet<GsmWorkflowNameValueAttributes> GsmWorkflowNameValueAttributes { get; set; }
        public virtual DbSet<GsmWorkflowProcessTemplates> GsmWorkflowProcessTemplates { get; set; }
        public virtual DbSet<GsmWorkflowTransitionTemplates> GsmWorkflowTransitionTemplates { get; set; }
        public virtual DbSet<HtmlData> HtmlData { get; set; }
        public virtual DbSet<HtmlMarkup> HtmlMarkup { get; set; }
        public virtual DbSet<ImportRequestQueue> ImportRequestQueue { get; set; }
        public virtual DbSet<IngCombStatementsFreeText> IngCombStatementsFreeText { get; set; }
        public virtual DbSet<IngStatementFreeText> IngStatementFreeText { get; set; }
        public virtual DbSet<IntoleranceContainedSourceMl> IntoleranceContainedSourceMl { get; set; }
        public virtual DbSet<Intolerances> Intolerances { get; set; }
        public virtual DbSet<IntolerancesContained> IntolerancesContained { get; set; }
        public virtual DbSet<IntolerancesPossiblyContained> IntolerancesPossiblyContained { get; set; }
        public virtual DbSet<IssueTrackingItem> IssueTrackingItem { get; set; }
        public virtual DbSet<LabelingSpec> LabelingSpec { get; set; }
        public virtual DbSet<LinearMeasure> LinearMeasure { get; set; }
        public virtual DbSet<LinearWorkflowConfigTokens> LinearWorkflowConfigTokens { get; set; }
        public virtual DbSet<LinearWorkflowWorkItemDo> LinearWorkflowWorkItemDo { get; set; }
        public virtual DbSet<Lioannotations> Lioannotations { get; set; }
        public virtual DbSet<LioauditHistoryItems> LioauditHistoryItems { get; set; }
        public virtual DbSet<LiodisplayMessagePctThreshold> LiodisplayMessagePctThreshold { get; set; }
        public virtual DbSet<Lioelements> Lioelements { get; set; }
        public virtual DbSet<LioelementSources> LioelementSources { get; set; }
        public virtual DbSet<LioprofileMl> LioprofileMl { get; set; }
        public virtual DbSet<Lioprofiles> Lioprofiles { get; set; }
        public virtual DbSet<Lioroots> Lioroots { get; set; }
        public virtual DbSet<LiostatementStyleLookupItems> LiostatementStyleLookupItems { get; set; }
        public virtual DbSet<LsLabelClaimMldo> LsLabelClaimMldo { get; set; }
        public virtual DbSet<LsLabelClaimRules> LsLabelClaimRules { get; set; }
        public virtual DbSet<LsLabelClaimRulesets> LsLabelClaimRulesets { get; set; }
        public virtual DbSet<LsLabelClaims> LsLabelClaims { get; set; }
        public virtual DbSet<LwfactivityOwnerConfigs> LwfactivityOwnerConfigs { get; set; }
        public virtual DbSet<MandatoryProperty> MandatoryProperty { get; set; }
        public virtual DbSet<ManuManufacturerSummary> ManuManufacturerSummary { get; set; }
        public virtual DbSet<MasterSpec> MasterSpec { get; set; }
        public virtual DbSet<MaterialSpec> MaterialSpec { get; set; }
        public virtual DbSet<NpdActDocumentCollaborations> NpdActDocumentCollaborations { get; set; }
        public virtual DbSet<NpdActDocumentCollaborations2> NpdActDocumentCollaborations2 { get; set; }
        public virtual DbSet<NpdActivities> NpdActivities { get; set; }
        public virtual DbSet<NpdActivityAttachments> NpdActivityAttachments { get; set; }
        public virtual DbSet<NpdActivityImcfkcssection7s> NpdActivityImcfkcssection7s { get; set; }
        public virtual DbSet<NpdActivityMl> NpdActivityMl { get; set; }
        public virtual DbSet<NpdActivityPackageCopies> NpdActivityPackageCopies { get; set; }
        public virtual DbSet<NpdActivityPackagingComponents> NpdActivityPackagingComponents { get; set; }
        public virtual DbSet<NpdActivityPostLaunchReviewMl> NpdActivityPostLaunchReviewMl { get; set; }
        public virtual DbSet<NpdActivityPostLaunchReviews> NpdActivityPostLaunchReviews { get; set; }
        public virtual DbSet<NpdActivityProcessMemorandums> NpdActivityProcessMemorandums { get; set; }
        public virtual DbSet<NpdActivityProjectScheduleMl> NpdActivityProjectScheduleMl { get; set; }
        public virtual DbSet<NpdActivityProjectSchedules> NpdActivityProjectSchedules { get; set; }
        public virtual DbSet<NpdActivitySections> NpdActivitySections { get; set; }
        public virtual DbSet<NpdActivityStageMilestoneMl> NpdActivityStageMilestoneMl { get; set; }
        public virtual DbSet<NpdActivityStageMilestones> NpdActivityStageMilestones { get; set; }
        public virtual DbSet<NpdActivityTemplateMl> NpdActivityTemplateMl { get; set; }
        public virtual DbSet<NpdActivityTemplates> NpdActivityTemplates { get; set; }
        public virtual DbSet<NpdActivityTemplateStepMl> NpdActivityTemplateStepMl { get; set; }
        public virtual DbSet<NpdActivityTemplateSteps> NpdActivityTemplateSteps { get; set; }
        public virtual DbSet<NpdActivityTypeMl> NpdActivityTypeMl { get; set; }
        public virtual DbSet<NpdActivityTypePbolinks> NpdActivityTypePbolinks { get; set; }
        public virtual DbSet<NpdActivityTypes> NpdActivityTypes { get; set; }
        public virtual DbSet<NpdActProjectSummaryUpdates> NpdActProjectSummaryUpdates { get; set; }
        public virtual DbSet<NpdActProjSchedCustMilestoneMl> NpdActProjSchedCustMilestoneMl { get; set; }
        public virtual DbSet<NpdActProjSchedCustMilestones> NpdActProjSchedCustMilestones { get; set; }
        public virtual DbSet<NpdActTemplateAssociations> NpdActTemplateAssociations { get; set; }
        public virtual DbSet<NpdActTemplateStepTransitions> NpdActTemplateStepTransitions { get; set; }
        public virtual DbSet<NpdAnswers> NpdAnswers { get; set; }
        public virtual DbSet<NpdAuditHistory> NpdAuditHistory { get; set; }
        public virtual DbSet<NpdAuditHistoryAssocUser> NpdAuditHistoryAssocUser { get; set; }
        public virtual DbSet<NpdBrands> NpdBrands { get; set; }
        public virtual DbSet<NpdChannels> NpdChannels { get; set; }
        public virtual DbSet<NpdClaims> NpdClaims { get; set; }
        public virtual DbSet<NpdConsumerValuePerception> NpdConsumerValuePerception { get; set; }
        public virtual DbSet<NpdCopyCategories> NpdCopyCategories { get; set; }
        public virtual DbSet<NpdCopyTexts> NpdCopyTexts { get; set; }
        public virtual DbSet<NpdCopyTypes> NpdCopyTypes { get; set; }
        public virtual DbSet<NpdDemographics> NpdDemographics { get; set; }
        public virtual DbSet<NpdEnablingTech> NpdEnablingTech { get; set; }
        public virtual DbSet<NpdEventHistory> NpdEventHistory { get; set; }
        public virtual DbSet<NpdGlobalCategories> NpdGlobalCategories { get; set; }
        public virtual DbSet<NpdGlobalUnitSize> NpdGlobalUnitSize { get; set; }
        public virtual DbSet<NpdIdea> NpdIdea { get; set; }
        public virtual DbSet<NpdideaMl> NpdideaMl { get; set; }
        public virtual DbSet<NpdIdeaOrigins> NpdIdeaOrigins { get; set; }
        public virtual DbSet<NpdIdeaTemplate> NpdIdeaTemplate { get; set; }
        public virtual DbSet<NpdIdeaTemplateMl> NpdIdeaTemplateMl { get; set; }
        public virtual DbSet<NpdMatrixGroups> NpdMatrixGroups { get; set; }
        public virtual DbSet<NpdMatrixItemMl> NpdMatrixItemMl { get; set; }
        public virtual DbSet<NpdMatrixItems> NpdMatrixItems { get; set; }
        public virtual DbSet<NpdMatrixRoles> NpdMatrixRoles { get; set; }
        public virtual DbSet<NpdMatrixUsers> NpdMatrixUsers { get; set; }
        public virtual DbSet<NpdNumberManager> NpdNumberManager { get; set; }
        public virtual DbSet<NpdPackageCopies> NpdPackageCopies { get; set; }
        public virtual DbSet<NpdpackageCopyMl> NpdpackageCopyMl { get; set; }
        public virtual DbSet<NpdPbolinkDescriptors> NpdPbolinkDescriptors { get; set; }
        public virtual DbSet<NpdPbolinks> NpdPbolinks { get; set; }
        public virtual DbSet<NpdPermissionTemplateItemCs> NpdPermissionTemplateItemCs { get; set; }
        public virtual DbSet<NpdPermissionTemplateItems> NpdPermissionTemplateItems { get; set; }
        public virtual DbSet<NpdPermissionTemplates> NpdPermissionTemplates { get; set; }
        public virtual DbSet<NpdPortfolioFilters> NpdPortfolioFilters { get; set; }
        public virtual DbSet<NpdPortfolioLayoutDefinitions> NpdPortfolioLayoutDefinitions { get; set; }
        public virtual DbSet<NpdPortfolioLayoutItems> NpdPortfolioLayoutItems { get; set; }
        public virtual DbSet<NpdPortfolioLayouts> NpdPortfolioLayouts { get; set; }
        public virtual DbSet<NpdPriorities> NpdPriorities { get; set; }
        public virtual DbSet<NpdProjCustMilestoneDefaultMl> NpdProjCustMilestoneDefaultMl { get; set; }
        public virtual DbSet<NpdProjCustomMilestoneDefault> NpdProjCustomMilestoneDefault { get; set; }
        public virtual DbSet<NpdProjectMilestoneDefaults> NpdProjectMilestoneDefaults { get; set; }
        public virtual DbSet<NpdProjectMl> NpdProjectMl { get; set; }
        public virtual DbSet<NpdProjectPortfolios> NpdProjectPortfolios { get; set; }
        public virtual DbSet<NpdProjects> NpdProjects { get; set; }
        public virtual DbSet<NpdProjectTemplateMl> NpdProjectTemplateMl { get; set; }
        public virtual DbSet<NpdProjectTemplates> NpdProjectTemplates { get; set; }
        public virtual DbSet<NpdProjectTypes> NpdProjectTypes { get; set; }
        public virtual DbSet<NpdProjectVisibilities> NpdProjectVisibilities { get; set; }
        public virtual DbSet<NpdQuestionDocumentTemplateMl> NpdQuestionDocumentTemplateMl { get; set; }
        public virtual DbSet<NpdQuestionDocumentTemplates> NpdQuestionDocumentTemplates { get; set; }
        public virtual DbSet<NpdQuestionGroupTemplateMl> NpdQuestionGroupTemplateMl { get; set; }
        public virtual DbSet<NpdQuestionGroupTemplates> NpdQuestionGroupTemplates { get; set; }
        public virtual DbSet<NpdQuestionMl> NpdQuestionMl { get; set; }
        public virtual DbSet<NpdQuestions> NpdQuestions { get; set; }
        public virtual DbSet<NpdRisks> NpdRisks { get; set; }
        public virtual DbSet<NpdSignatureRequests> NpdSignatureRequests { get; set; }
        public virtual DbSet<NpdStageMasterMl> NpdStageMasterMl { get; set; }
        public virtual DbSet<NpdStageMasters> NpdStageMasters { get; set; }
        public virtual DbSet<NpdStageMasterStageMl> NpdStageMasterStageMl { get; set; }
        public virtual DbSet<NpdStageMasterStages> NpdStageMasterStages { get; set; }
        public virtual DbSet<NpdStages> NpdStages { get; set; }
        public virtual DbSet<NpdStageTemplateMilestoneMl> NpdStageTemplateMilestoneMl { get; set; }
        public virtual DbSet<NpdStageTemplateMilestones> NpdStageTemplateMilestones { get; set; }
        public virtual DbSet<NpdStageTemplates> NpdStageTemplates { get; set; }
        public virtual DbSet<NpdStrategicBriefMl> NpdStrategicBriefMl { get; set; }
        public virtual DbSet<NpdStrategicBriefs> NpdStrategicBriefs { get; set; }
        public virtual DbSet<NpdStrategicBriefTemplateMl> NpdStrategicBriefTemplateMl { get; set; }
        public virtual DbSet<NpdStrategicBriefTemplates> NpdStrategicBriefTemplates { get; set; }
        public virtual DbSet<NpdTeamMemberFormulationGroups> NpdTeamMemberFormulationGroups { get; set; }
        public virtual DbSet<NpdTeamMemberFormulationUsers> NpdTeamMemberFormulationUsers { get; set; }
        public virtual DbSet<NpdTeamMembFormulationReqrmtMl> NpdTeamMembFormulationReqrmtMl { get; set; }
        public virtual DbSet<NpdTeamMembFormulationReqrmts> NpdTeamMembFormulationReqrmts { get; set; }
        public virtual DbSet<NpdTempSigAuthorities> NpdTempSigAuthorities { get; set; }
        public virtual DbSet<NpdToolboxEntry> NpdToolboxEntry { get; set; }
        public virtual DbSet<NpdWfguardConditionTemplates> NpdWfguardConditionTemplates { get; set; }
        public virtual DbSet<NpdWorkflowActionTemplates> NpdWorkflowActionTemplates { get; set; }
        public virtual DbSet<NpdWorkflowActivityTemplates> NpdWorkflowActivityTemplates { get; set; }
        public virtual DbSet<NpdWorkflowNameValueAttributes> NpdWorkflowNameValueAttributes { get; set; }
        public virtual DbSet<NpdWorkflowProcessTemplates> NpdWorkflowProcessTemplates { get; set; }
        public virtual DbSet<NpdWorkflowStatuses> NpdWorkflowStatuses { get; set; }
        public virtual DbSet<NpdWorkflowTransitionTemplates> NpdWorkflowTransitionTemplates { get; set; }
        public virtual DbSet<NsmNutrientAnalysis> NsmNutrientAnalysis { get; set; }
        public virtual DbSet<NsmNutrientAnalysisMl> NsmNutrientAnalysisMl { get; set; }
        public virtual DbSet<NsmNutrientComposite> NsmNutrientComposite { get; set; }
        public virtual DbSet<NsmNutrientCompositeItem> NsmNutrientCompositeItem { get; set; }
        public virtual DbSet<NsmNutrientCompositeMl> NsmNutrientCompositeMl { get; set; }
        public virtual DbSet<NutrientAnalysis> NutrientAnalysis { get; set; }
        public virtual DbSet<NutrientOptConstraints> NutrientOptConstraints { get; set; }
        public virtual DbSet<NutrientOptObjectives> NutrientOptObjectives { get; set; }
        public virtual DbSet<NutritionalOrigin> NutritionalOrigin { get; set; }
        public virtual DbSet<ObjectAssocationAttributes> ObjectAssocationAttributes { get; set; }
        public virtual DbSet<ObjectNameLookupFactory> ObjectNameLookupFactory { get; set; }
        public virtual DbSet<ObjectTypeAvailability> ObjectTypeAvailability { get; set; }
        public virtual DbSet<OptimizationBomItems> OptimizationBomItems { get; set; }
        public virtual DbSet<OptimizationSessions> OptimizationSessions { get; set; }
        public virtual DbSet<OrattributeMetaInfo> OrattributeMetaInfo { get; set; }
        public virtual DbSet<Orclassmetainfo> Orclassmetainfo { get; set; }
        public virtual DbSet<OrnamespaceMetaInfo> OrnamespaceMetaInfo { get; set; }
        public virtual DbSet<Orobjectassociationmetainfo> Orobjectassociationmetainfo { get; set; }
        public virtual DbSet<Orobjectpropertymetainfo> Orobjectpropertymetainfo { get; set; }
        public virtual DbSet<PackagingPreferences> PackagingPreferences { get; set; }
        public virtual DbSet<PackagingSpec> PackagingSpec { get; set; }
        public virtual DbSet<PackingConfigurationSpec> PackingConfigurationSpec { get; set; }
        public virtual DbSet<PackingSpec> PackingSpec { get; set; }
        public virtual DbSet<PermissionConditionObjects> PermissionConditionObjects { get; set; }
        public virtual DbSet<PermissionTemplateItemColls> PermissionTemplateItemColls { get; set; }
        public virtual DbSet<PermissionTemplateItems> PermissionTemplateItems { get; set; }
        public virtual DbSet<PermissionTemplates> PermissionTemplates { get; set; }
        public virtual DbSet<PersistentQueueNumberManager> PersistentQueueNumberManager { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PlantInfo> PlantInfo { get; set; }
        public virtual DbSet<PlmActivities> PlmActivities { get; set; }
        public virtual DbSet<PlmActivityAttachments> PlmActivityAttachments { get; set; }
        public virtual DbSet<PlmActivityMl> PlmActivityMl { get; set; }
        public virtual DbSet<PlmActivityTemplateMl> PlmActivityTemplateMl { get; set; }
        public virtual DbSet<PlmActivityTemplates> PlmActivityTemplates { get; set; }
        public virtual DbSet<PlmActivityTypeMl> PlmActivityTypeMl { get; set; }
        public virtual DbSet<PlmActivityTypes> PlmActivityTypes { get; set; }
        public virtual DbSet<PlmActTemplateAssociations> PlmActTemplateAssociations { get; set; }
        public virtual DbSet<PlmAnalyticMl> PlmAnalyticMl { get; set; }
        public virtual DbSet<PlmAnalytics> PlmAnalytics { get; set; }
        public virtual DbSet<PlmAnalyticSeries> PlmAnalyticSeries { get; set; }
        public virtual DbSet<PlmAnswers> PlmAnswers { get; set; }
        public virtual DbSet<PlmAuditHistory> PlmAuditHistory { get; set; }
        public virtual DbSet<PlmFieldExchangeBases> PlmFieldExchangeBases { get; set; }
        public virtual DbSet<PlmFieldExchangeCategories> PlmFieldExchangeCategories { get; set; }
        public virtual DbSet<PlmFieldExchangeDefinitionMl> PlmFieldExchangeDefinitionMl { get; set; }
        public virtual DbSet<PlmFieldExchangeDefinitions> PlmFieldExchangeDefinitions { get; set; }
        public virtual DbSet<PlmFieldExchangeDefModels> PlmFieldExchangeDefModels { get; set; }
        public virtual DbSet<PlmFieldExchangeFiscalYears> PlmFieldExchangeFiscalYears { get; set; }
        public virtual DbSet<PlmFieldExchangeGlobals> PlmFieldExchangeGlobals { get; set; }
        public virtual DbSet<PlmFieldExchangePhases> PlmFieldExchangePhases { get; set; }
        public virtual DbSet<PlmFieldExchangeUomlistMl> PlmFieldExchangeUomlistMl { get; set; }
        public virtual DbSet<PlmFieldExchangeUomlists> PlmFieldExchangeUomlists { get; set; }
        public virtual DbSet<PlmFieldExchangeValues> PlmFieldExchangeValues { get; set; }
        public virtual DbSet<PlmFieldExchDefinitionModelMl> PlmFieldExchDefinitionModelMl { get; set; }
        public virtual DbSet<PlmFunctionalAreas> PlmFunctionalAreas { get; set; }
        public virtual DbSet<PlmMultiPartAttachments> PlmMultiPartAttachments { get; set; }
        public virtual DbSet<PlmProjCustMilestoneDefaultDo> PlmProjCustMilestoneDefaultDo { get; set; }
        public virtual DbSet<PlmProjCustMilestoneDefMldo> PlmProjCustMilestoneDefMldo { get; set; }
        public virtual DbSet<PlmProjectTypes> PlmProjectTypes { get; set; }
        public virtual DbSet<PlmQuestionDocumentTemplateMl> PlmQuestionDocumentTemplateMl { get; set; }
        public virtual DbSet<PlmQuestionDocumentTemplates> PlmQuestionDocumentTemplates { get; set; }
        public virtual DbSet<PlmQuestionGroupTemplateMl> PlmQuestionGroupTemplateMl { get; set; }
        public virtual DbSet<PlmQuestionGroupTemplates> PlmQuestionGroupTemplates { get; set; }
        public virtual DbSet<PlmQuestionMl> PlmQuestionMl { get; set; }
        public virtual DbSet<PlmQuestionRelations> PlmQuestionRelations { get; set; }
        public virtual DbSet<PlmQuestions> PlmQuestions { get; set; }
        public virtual DbSet<PlmSignatureRequests> PlmSignatureRequests { get; set; }
        public virtual DbSet<PlmStageGateWorkflowStatuses> PlmStageGateWorkflowStatuses { get; set; }
        public virtual DbSet<PlmStages> PlmStages { get; set; }
        public virtual DbSet<PlmStageTemplateMilestoneMl> PlmStageTemplateMilestoneMl { get; set; }
        public virtual DbSet<PlmStageTemplateMilestones> PlmStageTemplateMilestones { get; set; }
        public virtual DbSet<PlmStageTemplates> PlmStageTemplates { get; set; }
        public virtual DbSet<PlmTableQuestionCaptions> PlmTableQuestionCaptions { get; set; }
        public virtual DbSet<PlmTeamMemberFormulationGroups> PlmTeamMemberFormulationGroups { get; set; }
        public virtual DbSet<PlmTeamMemberFormulationUsers> PlmTeamMemberFormulationUsers { get; set; }
        public virtual DbSet<PlmTeamMembFormulationReqrmtMl> PlmTeamMembFormulationReqrmtMl { get; set; }
        public virtual DbSet<PlmTeamMembFormulationReqrmts> PlmTeamMembFormulationReqrmts { get; set; }
        public virtual DbSet<PlmTempSigAuthorities> PlmTempSigAuthorities { get; set; }
        public virtual DbSet<PlmUserGroupContainers> PlmUserGroupContainers { get; set; }
        public virtual DbSet<PlufreeText> PlufreeText { get; set; }
        public virtual DbSet<PmaAuditHistory> PmaAuditHistory { get; set; }
        public virtual DbSet<PosfreeText> PosfreeText { get; set; }
        public virtual DbSet<PqmAudits> PqmAudits { get; set; }
        public virtual DbSet<PqmSummary> PqmSummary { get; set; }
        public virtual DbSet<Pqsfactor> Pqsfactor { get; set; }
        public virtual DbSet<PqsfactorInstance> PqsfactorInstance { get; set; }
        public virtual DbSet<PqsfactorOption> PqsfactorOption { get; set; }
        public virtual DbSet<PqsfactorTestingProtocolId> PqsfactorTestingProtocolId { get; set; }
        public virtual DbSet<Pqssample> Pqssample { get; set; }
        public virtual DbSet<PqssampleType> PqssampleType { get; set; }
        public virtual DbSet<Pqsscorecard> Pqsscorecard { get; set; }
        public virtual DbSet<Pqssection> Pqssection { get; set; }
        public virtual DbSet<PqssectionInstance> PqssectionInstance { get; set; }
        public virtual DbSet<Pqssession> Pqssession { get; set; }
        public virtual DbSet<PqssessionToSample> PqssessionToSample { get; set; }
        public virtual DbSet<Pqstemplate> Pqstemplate { get; set; }
        public virtual DbSet<RaccproductCategory> RaccproductCategory { get; set; }
        public virtual DbSet<RatingObservations> RatingObservations { get; set; }
        public virtual DbSet<ReconEquivTargets> ReconEquivTargets { get; set; }
        public virtual DbSet<RefAmountsCustomarilyConsumed> RefAmountsCustomarilyConsumed { get; set; }
        public virtual DbSet<RegFsisapplication> RegFsisapplication { get; set; }
        public virtual DbSet<RegFsisapplicationType> RegFsisapplicationType { get; set; }
        public virtual DbSet<RegFsisapplicationTypeMl> RegFsisapplicationTypeMl { get; set; }
        public virtual DbSet<RegRegulatoryAuth> RegRegulatoryAuth { get; set; }
        public virtual DbSet<RegRegulatoryAuthMldo> RegRegulatoryAuthMldo { get; set; }
        public virtual DbSet<RegRegulatoryCategory> RegRegulatoryCategory { get; set; }
        public virtual DbSet<ReportRequest> ReportRequest { get; set; }
        public virtual DbSet<RichTextSupportingDoc> RichTextSupportingDoc { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RollupCosts> RollupCosts { get; set; }
        public virtual DbSet<ScrmAddress> ScrmAddress { get; set; }
        public virtual DbSet<ScrmAuditHistory> ScrmAuditHistory { get; set; }
        public virtual DbSet<ScrmCompany> ScrmCompany { get; set; }
        public virtual DbSet<ScrmCompanySpecialAttributes> ScrmCompanySpecialAttributes { get; set; }
        public virtual DbSet<ScrmContact> ScrmContact { get; set; }
        public virtual DbSet<ScrmContactCategory> ScrmContactCategory { get; set; }
        public virtual DbSet<ScrmEntity> ScrmEntity { get; set; }
        public virtual DbSet<ScrmEntityFreeTextName> ScrmEntityFreeTextName { get; set; }
        public virtual DbSet<ScrmEntityFreeTextNotes> ScrmEntityFreeTextNotes { get; set; }
        public virtual DbSet<ScrmEntityRelationship> ScrmEntityRelationship { get; set; }
        public virtual DbSet<ScrmEntityStatBusRelationship> ScrmEntityStatBusRelationship { get; set; }
        public virtual DbSet<ScrmEntityStatus> ScrmEntityStatus { get; set; }
        public virtual DbSet<ScrmFacility> ScrmFacility { get; set; }
        public virtual DbSet<ScrmFacilitySpecialAttributes> ScrmFacilitySpecialAttributes { get; set; }
        public virtual DbSet<ScrmLegalAggreementMl> ScrmLegalAggreementMl { get; set; }
        public virtual DbSet<ScrmLegalAgreement> ScrmLegalAgreement { get; set; }
        public virtual DbSet<ScrmRelationshipType> ScrmRelationshipType { get; set; }
        public virtual DbSet<ScrmSignatureDocs> ScrmSignatureDocs { get; set; }
        public virtual DbSet<ScrmSourcingApproval> ScrmSourcingApproval { get; set; }
        public virtual DbSet<ScrmSourcingApprovalBase> ScrmSourcingApprovalBase { get; set; }
        public virtual DbSet<ScrmSourcingApprovalChecklist> ScrmSourcingApprovalChecklist { get; set; }
        public virtual DbSet<ScrmSourcingApprovalMl> ScrmSourcingApprovalMl { get; set; }
        public virtual DbSet<ScrmSourcingApprovalNonSpec> ScrmSourcingApprovalNonSpec { get; set; }
        public virtual DbSet<ScrmSourcingType> ScrmSourcingType { get; set; }
        public virtual DbSet<ScrmSrcingApprChecklistItem> ScrmSrcingApprChecklistItem { get; set; }
        public virtual DbSet<ScrmsupplierBase> ScrmsupplierBase { get; set; }
        public virtual DbSet<ScrmWorkflowAuditHistory> ScrmWorkflowAuditHistory { get; set; }
        public virtual DbSet<ScrmWorkflowOwner> ScrmWorkflowOwner { get; set; }
        public virtual DbSet<SdmcommonLookupJoin> SdmcommonLookupJoin { get; set; }
        public virtual DbSet<SearchableModelColumnInfo> SearchableModelColumnInfo { get; set; }
        public virtual DbSet<SearchableModelInfo> SearchableModelInfo { get; set; }
        public virtual DbSet<SecuredObjectType> SecuredObjectType { get; set; }
        public virtual DbSet<SecurityAccessLevel> SecurityAccessLevel { get; set; }
        public virtual DbSet<SecurityClassification> SecurityClassification { get; set; }
        public virtual DbSet<SecurityMl> SecurityMl { get; set; }
        public virtual DbSet<SecurityPrivilege> SecurityPrivilege { get; set; }
        public virtual DbSet<ShelfLifeTypes> ShelfLifeTypes { get; set; }
        public virtual DbSet<SmartIssueRequest> SmartIssueRequest { get; set; }
        public virtual DbSet<SmartIssueRequestMl> SmartIssueRequestMl { get; set; }
        public virtual DbSet<SpecActivitySpecification> SpecActivitySpecification { get; set; }
        public virtual DbSet<SpecAnalyticalPropertyScoring> SpecAnalyticalPropertyScoring { get; set; }
        public virtual DbSet<SpecAuditHistory> SpecAuditHistory { get; set; }
        public virtual DbSet<SpecAvailUomjoin> SpecAvailUomjoin { get; set; }
        public virtual DbSet<SpecClassificationAttr> SpecClassificationAttr { get; set; }
        public virtual DbSet<SpecDescriptionFreeTextProp> SpecDescriptionFreeTextProp { get; set; }
        public virtual DbSet<SpecImedPkgMaterialJoin> SpecImedPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecImedPrintPkgMaterialJoin> SpecImedPrintPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecInnerPkgMaterialJoin> SpecInnerPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecInnerPrintPkgMaterialJoin> SpecInnerPrintPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecLabelPkgMaterialJoin> SpecLabelPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecLabelPrintPkgMaterialJoin> SpecLabelPrintPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecLegacyProfile> SpecLegacyProfile { get; set; }
        public virtual DbSet<SpecLegacySpecJoin> SpecLegacySpecJoin { get; set; }
        public virtual DbSet<SpecLineageHistory> SpecLineageHistory { get; set; }
        public virtual DbSet<SpecMatAttrFreeTextShipInst> SpecMatAttrFreeTextShipInst { get; set; }
        public virtual DbSet<SpecMatAttribFreeText> SpecMatAttribFreeText { get; set; }
        public virtual DbSet<SpecMatAttribFreeTextRelaHum> SpecMatAttribFreeTextRelaHum { get; set; }
        public virtual DbSet<SpecMaterialAttributes> SpecMaterialAttributes { get; set; }
        public virtual DbSet<SpecMaterialBreakdown> SpecMaterialBreakdown { get; set; }
        public virtual DbSet<SpecOuterPkgMaterialJoin> SpecOuterPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecOuterPrintPkgMaterialJoin> SpecOuterPrintPkgMaterialJoin { get; set; }
        public virtual DbSet<SpecPackagingPkgAttribute> SpecPackagingPkgAttribute { get; set; }
        public virtual DbSet<SpecPackagingWasteClass> SpecPackagingWasteClass { get; set; }
        public virtual DbSet<SpecPkgingPkgAttrRelHumidity> SpecPkgingPkgAttrRelHumidity { get; set; }
        public virtual DbSet<SpecPkgingPkgAttrStorageInst> SpecPkgingPkgAttrStorageInst { get; set; }
        public virtual DbSet<SpecProcessPackagingAttribute> SpecProcessPackagingAttribute { get; set; }
        public virtual DbSet<SpecScoringMethod> SpecScoringMethod { get; set; }
        public virtual DbSet<SpecStorageRequirements> SpecStorageRequirements { get; set; }
        public virtual DbSet<SpecSummary> SpecSummary { get; set; }
        public virtual DbSet<SpecSummaryName> SpecSummaryName { get; set; }
        public virtual DbSet<SpecSummaryReasonForChange> SpecSummaryReasonForChange { get; set; }
        public virtual DbSet<SpecTestingProtocolSection> SpecTestingProtocolSection { get; set; }
        public virtual DbSet<SpecToOutputRatioOptConstraint> SpecToOutputRatioOptConstraint { get; set; }
        public virtual DbSet<SpecToSpecRatioOptConstraint> SpecToSpecRatioOptConstraint { get; set; }
        public virtual DbSet<SpecTpsectionFreeTextName> SpecTpsectionFreeTextName { get; set; }
        public virtual DbSet<SpecUrcountries> SpecUrcountries { get; set; }
        public virtual DbSet<SpecUsageRestriction> SpecUsageRestriction { get; set; }
        public virtual DbSet<SpecUsageVariety> SpecUsageVariety { get; set; }
        public virtual DbSet<SpecWorkflowAuditHistory> SpecWorkflowAuditHistory { get; set; }
        public virtual DbSet<SpEvents> SpEvents { get; set; }
        public virtual DbSet<SpEventText> SpEventText { get; set; }
        public virtual DbSet<SpStatuses> SpStatuses { get; set; }
        public virtual DbSet<SpSupplierReps> SpSupplierReps { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<SupplierInitiatedQuestionaire> SupplierInitiatedQuestionaire { get; set; }
        public virtual DbSet<SupportingDocuments> SupportingDocuments { get; set; }
        public virtual DbSet<TableRenameLookup> TableRenameLookup { get; set; }
        public virtual DbSet<TargetMarket> TargetMarket { get; set; }
        public virtual DbSet<Taxonomy> Taxonomy { get; set; }
        public virtual DbSet<TaxonomyTranslations> TaxonomyTranslations { get; set; }
        public virtual DbSet<TestingProtocol> TestingProtocol { get; set; }
        public virtual DbSet<TestingProtocolDescription> TestingProtocolDescription { get; set; }
        public virtual DbSet<TestingProtocolName> TestingProtocolName { get; set; }
        public virtual DbSet<TestingProtocolsContainer> TestingProtocolsContainer { get; set; }
        public virtual DbSet<TestingProtocolScopeMl> TestingProtocolScopeMl { get; set; }
        public virtual DbSet<TestingProtocolSelection> TestingProtocolSelection { get; set; }
        public virtual DbSet<TestingProtocolStatusMl> TestingProtocolStatusMl { get; set; }
        public virtual DbSet<TestProtocolAnalyticalProperty> TestProtocolAnalyticalProperty { get; set; }
        public virtual DbSet<TestProtocolAnalytSpecLimits> TestProtocolAnalytSpecLimits { get; set; }
        public virtual DbSet<TestProtocolAnalytTestUsed> TestProtocolAnalytTestUsed { get; set; }
        public virtual DbSet<TheoreticalCalculation> TheoreticalCalculation { get; set; }
        public virtual DbSet<TheoreticalCompliance> TheoreticalCompliance { get; set; }
        public virtual DbSet<TheoreticalEnvWaste> TheoreticalEnvWaste { get; set; }
        public virtual DbSet<TheoreticalExtendedAttribute> TheoreticalExtendedAttribute { get; set; }
        public virtual DbSet<TheoreticalNutrition> TheoreticalNutrition { get; set; }
        public virtual DbSet<TheoreticalSubcomponentAttr> TheoreticalSubcomponentAttr { get; set; }
        public virtual DbSet<TheoRollupCompliance> TheoRollupCompliance { get; set; }
        public virtual DbSet<TimeInterval> TimeInterval { get; set; }
        public virtual DbSet<TimeZones> TimeZones { get; set; }
        public virtual DbSet<TotalSolidsOptConstraint> TotalSolidsOptConstraint { get; set; }
        public virtual DbSet<TradePreferences> TradePreferences { get; set; }
        public virtual DbSet<UgmChangeRequestEvent> UgmChangeRequestEvent { get; set; }
        public virtual DbSet<UgmGroupChangeRequest> UgmGroupChangeRequest { get; set; }
        public virtual DbSet<Uom> Uom { get; set; }
        public virtual DbSet<Uomcategory> Uomcategory { get; set; }
        public virtual DbSet<UomcategoryMl> UomcategoryMl { get; set; }
        public virtual DbSet<Uomml> Uomml { get; set; }
        public virtual DbSet<UomnamedLists> UomnamedLists { get; set; }
        public virtual DbSet<Urlsource> Urlsource { get; set; }
        public virtual DbSet<UserAvailableLanguage> UserAvailableLanguage { get; set; }
        public virtual DbSet<UserChangeRequestAction> UserChangeRequestAction { get; set; }
        public virtual DbSet<UserEdit> UserEdit { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserScrmpreference> UserScrmpreference { get; set; }
        public virtual DbSet<WasteMaterialClass> WasteMaterialClass { get; set; }
        public virtual DbSet<WfadminRegisteredItem> WfadminRegisteredItem { get; set; }
        public virtual DbSet<WorkflowAssignedResources> WorkflowAssignedResources { get; set; }
        public virtual DbSet<WorkflowGroupMapTaxonomy> WorkflowGroupMapTaxonomy { get; set; }
        public virtual DbSet<WorkflowResource> WorkflowResource { get; set; }
        public virtual DbSet<WorkflowTransitionResource> WorkflowTransitionResource { get; set; }

        // Unable to generate entity type for table 'dbo.scrmSACSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IntolerancesNotContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICCompliesWithJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.simplotTranslationItemValues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributetypeml_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmPrintModelOptionsAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmNonSACSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqMatQShippingReqsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comextendedattributegroupjoin_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.filterdefinition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_CaseSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DataObjectNames'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.extattributeuomavailabilities_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmPrintModelFacilityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AvailDataItemFilterCriteria'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecCompliesWithJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CaseSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmMatBreakdownCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AllergensPossiblyContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.extattributedynamictagjoins_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DataItemFilterStore'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LIORootRestrictionsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_supportingDocuments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdditivesPossiblyContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AvailEADataItemFilterCriteria'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecificationWorkflowStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmEntityStatusBUsRelBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationPreferences'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_attachments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IntolerancesPossContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattribtuetype_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.objectTypesDefinition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specImedDeliverMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DUAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_DrlAttachmentReference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecConceptJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributetypeml_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PackagingInventoryStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_mig_drlAttRef'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.extattributedynamictagjoins_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentBusinessUnitsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackagingInventoryStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecPotentialLabelClaimJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_mig_ghostAttach'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.extattributeUOMavailabilities_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentClassificationJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Graphic_Features_Regulatory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmEquipmentSpecPkgSpecJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecActualLabelClaimJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_mig_ghostSupportDoc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comextendedattrubutegroupjoin_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DataItemEAFilterStore'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentNumManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Graphic_Features_Regulatory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lsLabelClaimBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_mig_nonAttProcSupDoc_Atts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.foodServiceProdBrkdownsSACJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextattributypeclassjoin_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentVisibilityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmFacilityDRLCatalogJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commoneatypeavailabin_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecTypes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDPrivateProjectUsersDenorm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OwnerDrlDocumentsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ColumnRenameLookup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmActions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttrTypeCategoryJoin_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDActCurrentStepUsersDenorm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specMaterialBreakdowns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PalletizerInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.userconceptjoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeQuality_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_CS_TABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specIngredientStatements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PalletizerInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmEntityFreeText'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttributeQualityML_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_CS_COLUMN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specInnerDeliverMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DrlAttachmentBlobStorage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NutrientUserDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.orpropertymetainfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmIssues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrQualityList_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CartonSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_CS_ROW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmIssueType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmUserConceptJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqMatBreakdownCompliesWithJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ConfigurationDictionary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEATypeAvailIn'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specLegacyProfileCountry'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spSpRepSCRMFacilitiesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comextattrcustomlookupjoin_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GroupRolesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specMasterJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PackagingData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Day_Code'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commoneareferenceditem_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.companyAddlAdminUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecNumManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LWFAllowedExtendedBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackagingData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Day_Code'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmIssueSystemType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributetype_bak3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TechnicalFeasibilitySummary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.companyAddlAdminGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specOuterDeliverMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LWFActivityExtBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comEACSCatAvailINJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMWFExtendedBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmUGSToEquipmentSpecMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSummaryProductLineJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributetype_bak4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CommonEACSCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OptimizationConstraints'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmUserContainerUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmItemBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FilmSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CommonEACSCategoryML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmCommonNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmUserContainerGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmItemOwners'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comStdNutrPropTestMethodJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackagingToPrintedPackaging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdStageTemplates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMAttachment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.templateattributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqSupplierNutrientsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserRolesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdProjCustomMilestoneDefault'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_ADMIN_Custom_Section_Training'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMSupportingDocument'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.templateConfigurations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdProjectMilestoneDefaults'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ADMIN_Custom_Section_Training'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMDocumentContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmEquipmentSpecSubcomponent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmTareWeightContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExplicitMasterSpec'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatSpecSubMaterialTagJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.linkableToActivity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpPrintWidths'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjTemplateReaderUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Project_Proposal_Part_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMTags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comWFStatusProcTemplTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_GeneralRequirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmBaseSpec'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectReaderUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdActivityTempStepOwnersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Project_Proposal_Part_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMTypes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lookupAssociatedSystemTypeBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GeneralRequirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FacilityTestingProtocolJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjTemplReaderGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSSpecLegacySpecJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedLanguageDisplayNames'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lookupAssociatedSubTypeBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFunctAreasSMILTaxNodeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectReaderGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGACTIVENUTRIENTPROFILE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdActivityStageBeginML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedCultureNamesNew'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmActionSystemType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmFPPackagingjoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DWBSpecRootReadersByUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGADMINLISTITEM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdActivityStageBegins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqRequestBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMAttachmentTagJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmActionType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmPackagingItemType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OptimizationObjectives'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmCompanyBuJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DWBSpecRootReadersByGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGBASESPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdActivityProjectSchedules'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Procurement_Assessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMRichTextTagJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAuditSystemType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_ForeignMaterialRequirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmPackagingItemTypeMML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmContactCategoryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DWBSpecRootEditorsByUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMMONBUSINESSUNIT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TnpdActivityProjectScheduleML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Procurement_Assessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMRichTextDoc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAuditType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ForeignMaterialRequirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityBrandJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DWBSpecRootEditorsByGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdPortfolioLayoutShareJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMMONLOOKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonTranslationCachesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specUsageVarietyCountries'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonServiceCacheGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.URLSourceTagJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSummarySCRMCompanyJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_FilmProductWeightInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserAvailableLanguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmEntityCertificationJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPANYPROFILE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserSettingsSelections'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonServiceCacheGrpRoleJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMBaseAttachment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSummarySCRMFacilityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.attribs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FilmProductWeightInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityChannelJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserComplimentaryLanguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customlookup_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmEntityNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPANYPROFILEBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.XREF_CONFIG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonTranslationItemsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedCultNameJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMBaseAttachmentTagJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSummaryCustomerJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttributeGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityDemographicsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserDRLCatalogJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmFacilityBuJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPANYRELATIONSHIP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedCultureDisplayNames'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_QualityAssessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SDMAttachContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmActionProblemStatementML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrpecTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityGlobalCategoryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmSrcingApprAuditorUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATALIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EASectionTemplateToSpecJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QualityAssessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentTags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmRelatedItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityKeySponsorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonNumberManagerLong'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmSrcingApprBuyerUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PticAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATLIOBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedLanguages'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DrlDocDocTagJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmRelatedAction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityLeadCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEAColumnInstance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmSourcingApprovalTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATLIOCONSTRAINT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqRequestAddlAdminGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQTUserBasedModelInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmRelatedIssue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityProjectVisibilityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LIONodeAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmSrcingApprUsedInFacJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATLIODISCLOSURE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqRequestAddlAdminUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAffectedObjectBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbPkgMaterialSpecStepJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_TechnicalAssessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityStrategicBriefJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LIOSourceNodeAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecRelationshipJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATLIOGROUPING'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_TheoreticalConstitution_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAffectedSpec'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TechnicalAssessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdEntityTeamLeadersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmCrossRefType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPCATRECONEQUIV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysicalReqColor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TheoreticalConstitution'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SmartIssueRelationshipJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LIOSubElementsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cssTradPartnrRetailerToTaxJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAffectedSCRMEntity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmCrossRefTypeMML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOMPONENTCATALOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationClassUserGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqSLAAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAffectedItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specPackSize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSuccReqAllowedParentsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCONTACTBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestingProtocolSelectionsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditConceptJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_GraphicCoding'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdMasterProjectTemplateJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CrossRefUOMJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customlookup_bak2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comEACategoryLookupMgrMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSuccReqSelectedParentsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCOST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_gsmNutrientItem_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CACSExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSecurityClassification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdStageMasterStagesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GraphicCoding'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdMasterStratBriefTemplJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGDELIVEREDMATLPACKSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BrkdwnFormulationClassJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmNutrientItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DRLExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Chemical_Requirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttMultiLingualText'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GroupAncestors'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdMatrixItemGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackSizeUOMJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbFormulatItemToSpecStepJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customlookup_bak3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SuccessionRequestNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGEXTENDEDATTRIBUTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodSvcFormulationClassJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UOMNamedListJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditRolesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrTextML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdMatrixItemRoleJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbSpecAdditivesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.simplotTranslationItemValues_bak_20170914'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFACILITYPROFILE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DataSourceMemberCounts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedCultures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmGroupCRUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbFormulationTagsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdMatrixItemUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PerformanceInstrumentationCfg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbSpecAllergensJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFACILITYPROFILEBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulaClassOverrideJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shelfLifeStorageReqrmentsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonExtendedAttributeNumeric_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UnitMeasure'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmGroupCRRolesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMSupportingDocumentsGSM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PerformanceInstrumentationEvt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbSpecCompliesWithJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFCLSOURCE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.signatureDocOwnerBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdPackageCopyCopyTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQMExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UsageRestrictionsCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmGroupCRGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMAttachmentGSM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StatusAwareClasses'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectPortfolioToUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationInputExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spSupplierRepSCRMCompaniesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFCLFOODGROUP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.signatureDocBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtAttribTypeClassJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmEntityFieldExchangeDefJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQSExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMRichTextDocGSM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_NPDGrahpicFeatures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjTemplateBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationInputCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFCLFOODITEM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSignatureDocOwner'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeDefUOMJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REGExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comBreakdownsRestrictionsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cssWorkflowGroupMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpURLSourceGSM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDGrahpicFeatures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjTemplateProjectTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationOutputCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RatingObservationSelectedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFCLNUTRIENT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSignatureDoc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DynamicTagAppBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonExtendedAttributeText_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SCRMExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMSupportingDocumentsPQM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdQstDocTplToQuestGrpTmplJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationOutputExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONBREAKDOWN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSigDocWorkflowAuditHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtAttributeDynamicTagJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceExtendedData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMAttachmentPQM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdQuestionGroupTemplQuestJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AvailableInTagsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONFORMULA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmShelfLifeDynamicTagsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CACSExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WFActivityInstanceResJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMRichTextDocPQM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdStrategicBriefBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationTagsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonLookup_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nsmCompositeBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eaSectionDynamicTagJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DRLExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpURLSourcePQM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdStrategicBriefTemplBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulaAdjusters'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nsmNutrientAnalysisBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULALOOKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonLinearWorkflowActions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AnalysisRelatedCompositesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonExtendedAttributeDate_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.auditSectionTemplateTypesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_SDMSupportingDocumentNPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQSScorecardNumber'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmEntityBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationTagBehavior'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmUserBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONALTERNATEINPUT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtendedAttributeRoot'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbAdditivesNotContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WFIncomingTransitionsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_SDMAttachmentNPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmQstDocTemplToQstGrpTmplJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationTagNameML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmUserDelegatableBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nsmCommonNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONINPUT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comLWFGuardConditions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GraphicColor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbAllergensNotContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WFOutgoingTransitionsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttrAvailabilityClasJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_URLSourceNPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQSSessionParticipantJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmQuestGrpTemplateQuestsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationTags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmAlternateSpecSupplybak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmUserDelegatableBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONPACKAGINGINPUT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQMExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbIntolerancesNotContainJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttrTypeCategoryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_DRLRefNPDAct'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmLWFTagGroupJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONOUTPUT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_comExtAttQuantitativeRange_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQSExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbSpecIntolerancesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WorkflowActivityInstAttr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProjectProposalPart3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_URLSourceNPDAct'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmMatBreakdownComplianceJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonSMILAncestorsDescendants'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationTagBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONINPUTCOMPOSITION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Graphic_Features'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REGExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSupportingDocumentContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMAttachmentDrlAttachment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PhysReqSensory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonSMILChildrenAncestor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SACCrossRefJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmLWFTagGroupJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONOUTPUTBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SCRMExtendedCustomerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpsdmattachmentfsis'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqProductShippingReqsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysReqSensory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductClassSyncWithItemJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CSSExtendedAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONOUTPUTADJUSTERS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceExtendedCustData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WFActInstanceDataArchive'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpsdmsupportingdocSCRM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecNutrientAttributeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.analyticalAffiliateJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqProductStorageReqsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFORMULATIONSTEP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_ExtAttrCalculationAttributes_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WFAssignedResourcesArchive'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.auditCriteriaGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpsdmattachmentSDSCRM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specTestingProtocolJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonLifecycleEventSource'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGINGREDIENTSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.auditCriterionCAPJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpurlsourcesdscrm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGLABELINGSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDDataObjectLockVersion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysicalReqDefect'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdActTemplPBOLinkDescriptJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpsdmspecattachmentscrm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaxonomyNamespaceAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGLEGACYPROFILE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditLogHighLevel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmInnerInterOutrPkgingMatBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpsdmspecurlsourcetscrm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.workflowMapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonSMILTaxonomyNodeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGLIOPROFILEBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ORClassMetaDataCleanInfoTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_ExtAttrQualitativeLookup_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WorkflowProcessInstanceAttr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSupportingDocAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpeqmatsection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cpParticipants'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmEntityAltSupplyTaxonJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGMASTERSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpEqPackSection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGMENUITEMSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CommonEventingLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonAuditManagers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmNonStandardPalletAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpEqProdSection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmFacilityParticipants'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGMENUITEMBUILD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDLabelInformationSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditChange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdQuestionTableCaptionJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmNutrientPanelItemEquivs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpEqPrintedPkg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGMENUITEMALTERNATE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonEAReferencedItem_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditChangeDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdQuestionTranslationItemJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpEqTrade'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGNUTRIENTCOMPOSITION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OwnerDrlCatalogsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMAttachmentPQS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CountryMaterialAttrJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmAssociatedProject'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQTSearchCriteriaAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGNUTRIENTPROFILESPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpSDMAttachmentSI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FactoryTestingProtocolJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DenormSequenceNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.denorm_cs_table_bak_03152018'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGPACKAGINGMATERIALSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dnDBWarehouseLangs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WorkflowTransitionDataAttr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrLongTextML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_CS_REQUEST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cssPublishableGSMWFStatusJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.denorm_cs_row_bak_03152018'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGPACKINGCONFIGSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dnSCRMAction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_comEAReferencedItemCollection_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmQuestionTableCaptionJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtAttributeLongText'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_EA_REQUEST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaxonomyNodeAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.denorm_cs_column_bak_03152018'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGPRINTEDPACKAGINGSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExAttLongMultiLingualText'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestingProtocolNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cacsnumbermanager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InternalNonORMaintainedTables'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqsCommonNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGQUALITATIVEEXTATTR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmCompanyDRLCatalogJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmClassification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEASectionInstanceLoc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PhysReqCom'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmInerInterOutrPrntPkgMatBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OrigLangValues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGRELATEDSPECSIMPLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TradeBrand'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysReqCom'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSCRMADDRESS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_comExtendedAttrQualitative_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeCalcStrategy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonFacility'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmFormulationFacilityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RatingObservationsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSCRMCONTACT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cssSTmpUNSPSCCodes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqPkgQStorageReqsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeCalcStrategyML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.supplierportalloginoptions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSOURCINGAPPROVAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysiReqTexture'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Thumbnail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatClassAttrMatAttrJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdFieldExchangeBasisJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.usercomplimentarylanguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSOURCINGAPPROVALBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ThumbnailContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.syncUsersSecondary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdFieldExchangeCategoryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmUserBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSOURCINGAPPROVALALT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmWorkflowGroupMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonExtendedAttributeBoolean_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecClassificationMLBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdFieldExchangeFiscalYearJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comStdNutrientPropValidUOMJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GlobSuccRequestAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMSpecRelationship'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSOURCINGAPPROVALRCVFAC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CartonProductWeightInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserAvailableCulture'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatShippingRequirementsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdFieldExchangePhaseJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CountryOriginsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECASSOCIATEDSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmWorkflowStatusGSSIJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdPFieldExchangeBasisJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECBASEUOM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdActionItems'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatStorageRequirementsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjFieldExchangeBasisJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECCOMPLIANCEITEM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserEqtEquivalentPreference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonEASectionCellInstance_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjFieldExchFiscalYearJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECENVIRONMENTALWASTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LabelingPackingJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjFieldExchangePhaseJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICLIODisclosureGroupingsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECFACILITY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MultNA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.regFSISApplicationAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmPackagingSpecBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmEntityFieldExchDefModelJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECRELATEDPACKAGINGSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Graphic_Plates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceRelatedItemJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.langCountries'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReadyReportNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedDynamicTag'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BaseEntities'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECRELATEDSPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonEARowInstance_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceRelatedAltJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqAttachments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.langDuration'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeBasisJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.readyreport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICLIODisclosureRestrictJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Packaging_Requirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmUNSPSCCode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonBUChildrenAncestor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmSIEQAdditionalAdminsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECRLTDPACKINGCONFIG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdActTempStepSignaturesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeCategoryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Packaging_Requirements'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmItemTitle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonFunctionalAreaBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSHELFLIFE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdActTempStepNotifiesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonDataGroupLookupItemJoins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmLabelClaimSpecJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_OperationsProductionFeasibilit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.freeTextDescriptionML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmApprovedUsageBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSHELFLIFEBASE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyndicateConfigurations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQItemEARowInstance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CACSLowerLevelScreenJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SecurityClassAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserEditCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OperationsProductionFeasibilit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmPreventativeActionML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SupportedCulturesNew'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LWFNotificationRecipientJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSUBCOMPONENT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyndicatePublisherConfig'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpB935CB5F6428_commonEASectionInstance_PKID_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CACSAvailableInAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SecClassAttrJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FSISNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AnalyticalBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ContactCompanyRelationship'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangeFiscalYearJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmRootCauseAnalysisML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationSubMatRestrictJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LWFActivityOwnerConfigJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSUMMARY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Syndicates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEASectionInstance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserDRLCatalogJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LabelInformationSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ContactFacilityRelationship'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICTermNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmIssueAffectedItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LinearWorkflowSigDocJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSUPERCEDES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyndicateSubscriptionConfigs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaBusinessUnitJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row6'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccessPermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditDrlCatalogsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.manuMaterialSpecifications'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plmFieldExchangePhaseJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PhysReqTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comSPAExtendedBehaviorTemplate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comLWFTemplateTaxonomyJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECSUPPORTINGDOCUMENT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyndicateSubscriptions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaAdminUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row7'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TheoreticalEAConstitution'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.relatedobjects'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.xlateWorkbookExclusion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtAttributeUomAvailabilities'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysReqTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comSPAExtBehaviorTemplateML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LinearWorkflowNotificationJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECTAREWEIGHT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyndicateNamespaceConfig'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaAdminGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customerTranslationItemValues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqPPkgQeqMarkingsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SPAExtendedBehaviorJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comLWFTemplateTypeTaxonomyJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGTRADESPEC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row8'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEAReferencedItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpAttachmentsDRLAttachmentsMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TieSlipSheetInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonSegAncestorsDescendants'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqPPkgQLanguagesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMDataObjectLockVersion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGUGMUSER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Row9'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdCopyTypeSMILTaxonmyNodeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonSegChildrenAncestor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGUGMUSERLANGUAGE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaTemplateBUJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RiskOpportunityMatrix'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LocalAttributeOverride'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonLanguageML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comSegAncestorsDescSecondary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SCRMDataObjectLockVersion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.regAuthLabelClaimJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmNCRContainmentActions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LIONumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGADDITIVES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecLanguageJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaTemplateAdminUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonLanguages'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.regCatRegAuthJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmLifecycleEventLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGFOODSERVICEPRODUCT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaTemplateAdminGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtAttrCalculationAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdPackageCopySupportedLangs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DRLDataObjectLockVersion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmLineageHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGCFIAAPPLICATION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ConvertTimeInterval'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.userClassificationPrivileges'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestProdFacilityMapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonBUAncestorsDescendants'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmWorkflowAuditHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SmartIssueRequestAttributes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGGENERICAPPLICATION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttrCustomLookupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CorrugatedProductWeightInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackagingStorageJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQMDataObjectLockVersion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmFormulationStepBehaviorType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SIRequestReaderGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGUSDAAPPLICATION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comBUAncestorsDescSecondary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrQualityJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqtSegmentUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackingConfigPackingSpecJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqSupplierAllergensJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spAdminCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_NPDPackagingInfoSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FormulationStepBehaviorTypeML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmApprovedUsageCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SIRequestReaderUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STGSPECAVAILUOM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEARowInstance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecNutrientProfileJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtAttributeSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqSupplierAdditivesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDPackagingInfoSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pqmSupplier'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SIRequestOwnerUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSCommonLookups'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eaSectionSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqSupplierIntolerancesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SIRequestOwnerGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductDescription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EASectionInstanceToColumnJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EQRequestSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PackingSpecLabelingJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpecificationTracks'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SmartIssueNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EATypeTargetMapCommnLookupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEASectionCellInstance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceStandard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PQMSummarySegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.versionHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectTemplateRoots'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatSpecMaterialTypeJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CasePacking'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NPDIdeaSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OperationsAssessment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeBoolean'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserEditSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dwbBreakdownRestrictionJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Project_Proposal_Estimated_Fin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tradeSpecStorageReqrmtsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_RigidSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AllergensUserDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DrlDocumentSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProcessSpecDataSourceHelper'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Project_Proposal_Estimated_Fin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RigidSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IntolerancesUserDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttQuantitativeRange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSM_FSIS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nsmNutCompositeSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductClassAttrJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserRolesJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdditivesUserDataGroupJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.securableObject'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LabelSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nsmNutAnalysisSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductStorageRequirementsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqtBUUserJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Numerics'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdTemplateAdminUsersJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ImpPlant'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdStratBriefTemplSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specBULegacyProfileJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.securableObjectContext'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdTemplateAdminGroupsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Graphic_Features_Marketing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdStrategicBriefSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqNumberManager'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUserEqtEquivalentPreference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectTemplateSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICLIOTermGroupingsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_PhysicalReqGeneral'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.securityClassLevelsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeText'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdIdeaTemplateSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICLIOTermDisclosureJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_FilmSupplierInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysicalReqGeneral'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DRLPrintIntregrationCleanup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.npdProjectSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specAltImedPkgMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MatBreakdownItemBase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FilmSupplierInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TheoreticalCosts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QualityAssuranceSummary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtendedAttrQualitative'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributeml_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ComplianceItemContained'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spSupplierRepSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdditivesNotContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specAltInnerPkgMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ComplianceUOMJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Texts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonearowtemplate_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AllergensNotContainedJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.specAltOuterPkgMaterialJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DENORM_Col1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtAttrQualitativeLookup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceItemClassJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.denorm_cs_row_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ugmUserDelegatableSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqMatBreakdownCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comExtAttrDisplayTextPropML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commoneasectioncelltemplate_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gsmSpecSegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqMatQCountryJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commoneasectioncelltemplate_bak4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeNumeric'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FoodServiceSpecification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextendedattributetype_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmCompanySegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STG_Regulatory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqClassificationAttrJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonearowtemplate_bak4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonEATypeavailin_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.scrmFacilitySegmentJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eqMatQStorageReqsJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Regulatory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonExtendedAttributeQAttr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.denorm_cs_row_bak4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.comEAReferencedItemCollection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.commonextattribtypeclassjoin_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PhysicalReqDimensions'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"server=occ00dv101;Database=prodikadb;Integrated Security=false;User ID=svc_plm;Password=rAF8wH4TLTdZUW;MultipleActiveResultSets=true");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditiveContainedSourceMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAdditiveContained)
                    .HasName("PLM4P_2181");
            });

            modelBuilder.Entity<Additives>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.Langid });
            });

            modelBuilder.Entity<AdditivesContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2177");

                entity.HasIndex(e => new { e.FkParent, e.FkAdditive })
                    .HasName("unq_additivescontained_fkparent_fkadditive")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AdditivesPossiblyContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2262");

                entity.HasIndex(e => new { e.FkParent, e.FkAdditive })
                    .HasName("unq_additivespossiblycontained_fkparent_fkadditive")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.FkPerson)
                    .HasName("PLM4P_1001_1");

                entity.HasIndex(e => e.FkUser)
                    .HasName("PLM4P_1001_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Affiliates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AllergenContainedSourceMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAllergen)
                    .HasName("PLM4P_2182");
            });

            modelBuilder.Entity<Allergens>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<AllergensContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2178");

                entity.HasIndex(e => new { e.FkParent, e.FkAllergen })
                    .HasName("unq_allergenscontained_fkparent_fkallergen")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AllergensPossiblyContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2260");

                entity.HasIndex(e => new { e.FkParent, e.FkAllergen })
                    .HasName("unq_allergenspossiblycontained_fkparent_fkallergen")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ApplicationBehaviors>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<AppliesTo>(entity =>
            {
                entity.HasIndex(e => e.FkMasterSpec)
                    .HasName("PLM4P_2073");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCorrectiveActionProtclsMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6218");
            });

            modelBuilder.Entity<AuditCoverPageFields>(entity =>
            {
                entity.HasIndex(e => e.FkAuditScorecard)
                    .HasName("PLM4P_6212");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCoverPageFieldTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCoverPageFieldTemplate)
                    .HasName("PLM4P_6213");
            });

            modelBuilder.Entity<AuditCoverPageFieldTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkAuditTemplate)
                    .HasName("PLM4P_6211");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCoverPageFieldUiinfo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCriteriaGroupMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6217_1");
            });

            modelBuilder.Entity<AuditCriterionEvaluations>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6210");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCriterionMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAuditCriterion)
                    .HasName("PLM4P_6201");
            });

            modelBuilder.Entity<AuditCriterions>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6200");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditCriterionScoringRuleMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCriterionScoringRule)
                    .HasName("PLM4P_6221");
            });

            modelBuilder.Entity<AuditCriterionScoringRules>(entity =>
            {
                entity.HasIndex(e => e.FkCriterion)
                    .HasName("PLM4P_6207");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkCriterion).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCustomAttributeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCustomAttribute)
                    .HasName("PLM4P_6220");
            });

            modelBuilder.Entity<AuditCustomAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6219");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttributeName).IsUnicode(false);

                entity.Property(e => e.AttributeNamespace).IsUnicode(false);

                entity.Property(e => e.AttributeType).IsUnicode(false);

                entity.Property(e => e.AttributeValue).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNumberManager>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditOnlineGuidanceSourceMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6215");

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<AuditRecords>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AuditRepeatableSectionTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditRepeatableSectionTypesMl>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6230");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditScorecards>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditScripts>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6226_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditScriptTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6224");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ScriptNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditScriptTemplatesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkScript)
                    .HasName("PLM4P_6225");
            });

            modelBuilder.Entity<AuditSections>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6209");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AuditSectionTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAuditSectionTemplate)
                    .HasName("PLM4P_6206");
            });

            modelBuilder.Entity<AuditSectionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6205");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.SectionNumber).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAuditTemplate)
                    .HasName("PLM4P_6204");
            });

            modelBuilder.Entity<AuditTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ShemaVersion).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTransitionTemplate>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6227");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Condition).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserNotificationMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAuditUserNotification)
                    .HasName("PLM4P_6223");
            });

            modelBuilder.Entity<AuditUserNotifications>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<BofContrivedChildren>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3051");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<BofContrivedEntities>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<BofContrivedEntitiesWithAttr>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<BofSimpleNameValueAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3053");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<BomItem>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5809_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ItemId).IsUnicode(false);

                entity.Property(e => e.RevisionId).IsUnicode(false);
            });

            modelBuilder.Entity<BreakdownReconEquivTargets>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsapprovedUsageAttribute>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsapprovedUsageAttributeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAttribute)
                    .HasName("PLM4P_6709");
            });

            modelBuilder.Entity<Cacsattribute>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsattributeContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsattributeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAttribute)
                    .HasName("PLM4P_6702");
            });

            modelBuilder.Entity<CacsavailableIn>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsavailableInMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAvailableIn)
                    .HasName("PLM4P_6711");
            });

            modelBuilder.Entity<CacscomplianceConstraint>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6703");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsconstraintItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsextAttributeConstraint>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6712");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsnutrientConstraint>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6706");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cacsscreen>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CacsusageApprovalConstraint>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6705");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsImportSubmission>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsImportType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CcmsStatuses>(entity =>
            {
                entity.HasIndex(e => e.StatusId)
                    .HasName("PLM4P_STATUSID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsStatusTextValues>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CcmsTranslationItemValStatuses>(entity =>
            {
                entity.HasIndex(e => e.FkTranslationItemValue)
                    .HasName("PLM4P_FKTRANSLATIONITEMVALUE")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.FkWorkset)
                    .HasName("PLM4P_FKWORKSET");

                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_PKID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsWorksetItemRejectComments>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsWorksetItems>(entity =>
            {
                entity.HasIndex(e => e.FkWorkset)
                    .HasName("PLM4P_FKWORKSET")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_PKID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CcmsWorksets>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CodeAgents>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Agentfactoryname).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Factoryargs).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CollapsibleContentStates>(entity =>
            {
                entity.HasKey(e => new { e.FkUser, e.ObjectType, e.ContentIdentifier });

                entity.Property(e => e.ContentIdentifier).IsUnicode(false);

                entity.Property(e => e.DisplayState).IsUnicode(false);
            });

            modelBuilder.Entity<ComCurrencyConvTimeFrameMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCurrencyConversionTimeFrame)
                    .HasName("PLM4P_2253");
            });

            modelBuilder.Entity<ComCurrencyConvTimeFrames>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComExtendedAttributeQualityMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkExtendedAttributeQuality)
                    .HasName("PLM4P_2263");
            });

            modelBuilder.Entity<ComExtendedAttrQualityList>(entity =>
            {
                entity.HasIndex(e => e.FkExtendedAttribute)
                    .HasName("PLM4P_2284");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComExtendedAttrStatusMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkExtendedAttributeStatus)
                    .HasName("PLM4P_2289");
            });

            modelBuilder.Entity<ComLwfactionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2204");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfactivityTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_2202");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfconfigurations>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ActionTemplateMgrFactoryUrl).IsUnicode(false);

                entity.Property(e => e.ActivityManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.ActivityOwnerManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.ActivityTemplateManagerFacUrl).IsUnicode(false);

                entity.Property(e => e.GuardConditionTemplMgrFacUrl).IsUnicode(false);

                entity.Property(e => e.NotifFunctionalAreaMgrFacUrl).IsUnicode(false);

                entity.Property(e => e.NotificationManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.ProcessManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.ProcessTemplateManagerFacUrl).IsUnicode(false);

                entity.Property(e => e.ProcessTemplateResolverUrl).IsUnicode(false);

                entity.Property(e => e.ResolutionSetManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.TransitionManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.TransitionTemplateMgrFacUrl).IsUnicode(false);

                entity.Property(e => e.WfstatusManagerFactoryUrl).IsUnicode(false);

                entity.Property(e => e.WorkflowManagerId).IsUnicode(false);
            });

            modelBuilder.Entity<ComLwfextBehaviorTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkLwfextendedBehaviorTemplate)
                    .HasName("PLM4P_2302");
            });

            modelBuilder.Entity<ComLwfextendedBehaviorTemplate>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfgaurdConditionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2203");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.GuardConditionInstanceFacUrl).IsUnicode(false);
            });

            modelBuilder.Entity<ComLwfnameValueAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2208");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfnotifications>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfprocessInstance>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfprocessTemplateEditor>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_2295");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Principle).IsUnicode(false);
            });

            modelBuilder.Entity<ComLwfprocessTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkLinearWfprocessTemplate)
                    .HasName("PLM4P_2247");
            });

            modelBuilder.Entity<ComLwfprocessTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfprocessTemplateTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.BusinessUnitTaxonomyNamespace).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.NotificationTokenDataSource).IsUnicode(false);

                entity.Property(e => e.StatusDataSource).IsUnicode(false);
            });

            modelBuilder.Entity<ComLwfsectionControl>(entity =>
            {
                entity.HasIndex(e => e.FkLinearWfuiconfiguration)
                    .HasName("PLM4P_2248");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ControlUrl).IsUnicode(false);

                entity.Property(e => e.LabelId).IsUnicode(false);
            });

            modelBuilder.Entity<ComLwftransitionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_2201");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComLwfuiconfiguration>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FirstStepControlUrl).IsUnicode(false);

                entity.Property(e => e.IntermediateStepControlUrl).IsUnicode(false);

                entity.Property(e => e.LastStepControlUrl).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.NotificationTokenDataSource).IsUnicode(false);

                entity.Property(e => e.ProcessInstanceViewControlUrl).IsUnicode(false);

                entity.Property(e => e.ProcessTemplSummaryControlUrl).IsUnicode(false);
            });

            modelBuilder.Entity<CommonActivitySpecLink>(entity =>
            {
                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_5825");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonAttributeRangeItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonBreakdowns>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_1018_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonBunamespace>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.NamespaceId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonBusinessUnit>(entity =>
            {
                entity.HasIndex(e => e.FkBunamespace)
                    .HasName("PLM4P_2107_1");

                entity.HasIndex(e => e.FkBusinessUnit)
                    .HasName("PLM4P_FKBUSINESSUNIT")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkBusinessUnit).IsUnicode(false);

                entity.Property(e => e.IsPhantom).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CommonBusinessUnitName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecBusinessUnit)
                    .HasName("PLM4P_FKSPECBUSINESSUNIT")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<CommonCacheFlushEvent>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AppName).IsUnicode(false);

                entity.Property(e => e.CacheName).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ServerName).IsUnicode(false);
            });

            modelBuilder.Entity<CommonCacheFlushRequest>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ContainedItemIds).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.SequenceNumber).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CommonConfigurationBundle>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonConfigurationEnvironment>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CommonConfigurationName>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonConfigurationNamespace>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ConfigValues).IsUnicode(false);

                entity.Property(e => e.FactoryClassname).IsUnicode(false);

                entity.Property(e => e.NamespaceId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonConfigurationRversion>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<CommonConfigurationType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CommonConfigurationValue>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonCurrencies>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonCurrenciesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCurrency)
                    .HasName("PLM4P_2146");
            });

            modelBuilder.Entity<CommonCurrencyConversionRates>(entity =>
            {
                entity.HasIndex(e => e.FkCurrency)
                    .HasName("PLM4P_2254");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonDataGroupMapping>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonDataMapException>(entity =>
            {
                entity.HasIndex(e => e.FkDataGroupMapping)
                    .HasName("PLM4P_2198");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonEacolumnTemplate>(entity =>
            {
                entity.HasIndex(e => e.FkSectionTemplate)
                    .HasName("PLM4P_1022");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonEarowTemplate>(entity =>
            {
                entity.HasIndex(e => e.FkSectionTemplate)
                    .HasName("PLM4P_1023");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonEasectionCellTemplate>(entity =>
            {
                entity.HasIndex(e => e.FkRowTemplate)
                    .HasName("PLM4P_1027");

                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_1027_PKID");

                entity.HasIndex(e => new { e.FkColumnTemplate, e.FkExtendedAttributeType, e.FkRowTemplate, e.Pkid })
                    .HasName("PLM4P_FKROWTEMPLATE_PKID_COMMONEASECTIONCELLTEMPLATE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonEasectionTemplate>(entity =>
            {
                entity.HasIndex(e => e.FkSecurityClassification)
                    .HasName("PLM4P_COMMONEASECTIONTEMPLATESEC");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DexVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonExtendedAttribOptionMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkExtendedAttributeOption)
                    .HasName("PLM4P_2316");
            });

            modelBuilder.Entity<CommonExtendedAttributeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_1021");
            });

            modelBuilder.Entity<CommonExtendedAttributeOptions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttributeType).IsUnicode(false);

                entity.Property(e => e.FieldId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonExtendedAttributeQuality>(entity =>
            {
                entity.HasIndex(e => e.FkQualityList)
                    .HasName("PLM4P_2285");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonExtendedAttributeStatus>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonExtendedAttributeType>(entity =>
            {
                entity.HasIndex(e => e.FkSecurityClassification)
                    .HasName("PLM4P_COMMONEXTENDEDATTRIBUTETYPE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttributeId).IsUnicode(false);

                entity.Property(e => e.AttributeType).IsUnicode(false);

                entity.Property(e => e.CalculationScriptEngine).IsUnicode(false);

                entity.Property(e => e.DexVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.ListUrl).IsUnicode(false);

                entity.Property(e => e.LookupJavascriptPropertyAlias).IsUnicode(false);

                entity.Property(e => e.LookupJspropertyAliasSearch).IsUnicode(false);

                entity.Property(e => e.LookupManagerId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonExtendedAttributeTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkExtendedAttributeType)
                    .HasName("PLM4P_2259");
            });

            modelBuilder.Entity<CommonExternalIdlookup>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonFunctionalUnits>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Pkid).HasDefaultValueSql("('2209' + upper(newid()))");

                entity.Property(e => e.LangId).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CommonLifecycleEventLog>(entity =>
            {
                entity.HasIndex(e => e.Pkid)
                    .HasName("UQ__commonLifecycleE__3065AE15")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.EventSource).IsUnicode(false);
            });

            modelBuilder.Entity<CommonLinearWorkflowActivities>(entity =>
            {
                entity.HasIndex(e => e.FkProcess)
                    .HasName("PLM4P_2206");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonLinearWorkflowProcesses>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonLinearWorkflowStatuses>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CommonLookups>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Pkid).HasDefaultValueSql("('2210' + upper(newid()))");

                entity.Property(e => e.LangId).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CommonLookupServiceManagers>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ConfigValues).IsUnicode(false);

                entity.Property(e => e.FactoryClassname).IsUnicode(false);

                entity.Property(e => e.ManagerId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonLwfprocessResolutionSet>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5813");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DataSource).IsUnicode(false);
            });

            modelBuilder.Entity<CommonLwfresSetParticipants>(entity =>
            {
                entity.HasIndex(e => e.FkParticipant)
                    .HasName("PLM4P_COMMONLWFRESSETPARTICIPANTSFKPARTICIPANT");

                entity.HasIndex(e => e.FkResolutionSet)
                    .HasName("PLM4P_5812");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonLwftransitions>(entity =>
            {
                entity.HasIndex(e => e.FkProcess)
                    .HasName("PLM4P_2207");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonManagedDocument>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2231");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonMultiPartAttachment>(entity =>
            {
                entity.HasIndex(e => e.FkEntity)
                    .HasName("PLM4P_5528");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonObjectMrulog>(entity =>
            {
                entity.HasIndex(e => e.FkObjectId)
                    .HasName("PLM4P_1017_FKOBJECTID");

                entity.HasIndex(e => new { e.FkUser, e.FkObjectId, e.Pkid })
                    .HasName("PLM4P_1017_FKUSER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.TypeId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonOwnedXdocument>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2190");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonReplicationHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);
            });

            modelBuilder.Entity<CommonSegment>(entity =>
            {
                entity.HasIndex(e => e.FkSegment)
                    .HasName("PLM4P_FK_1243");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonSegmentName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSegment)
                    .HasName("PLM4P_FK_1244");
            });

            modelBuilder.Entity<CommonServiceCache>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.Langid });

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonServiceCacheGroup>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.Langid });
            });

            modelBuilder.Entity<CommonSmiltaxonomyNode>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.IsPhantom).HasDefaultValueSql("(0)");

                entity.Property(e => e.Status).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<CommonSmiltaxonomyNodeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSmiltaxonomyNode)
                    .HasName("PLM4P_2142");
            });

            modelBuilder.Entity<CommonSubstituteLookups>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonSupportingXdocuments>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonTaxonomyBase>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.IsPhantom).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CommonTaxonomyNamespace>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ConfigValues).IsUnicode(false);

                entity.Property(e => e.FactoryClassname).IsUnicode(false);

                entity.Property(e => e.NamespaceId).IsUnicode(false);
            });

            modelBuilder.Entity<CommonTextRepository>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2214_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonTransactionId>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonTranslationCaches>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PLM4P_ID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonTranslationItems>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Context).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<CommonTranslationItemValues>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTranslationItem)
                    .HasName("PLM4P_2167");
            });

            modelBuilder.Entity<CommonWorkflowAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonWorkflowStatus>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CommonXlaextensionCache>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CommonXlaextensionCacheItem>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_1059");
            });

            modelBuilder.Entity<ComplianceItem>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ComplianceItemContainedSource>(entity =>
            {
                entity.HasIndex(e => e.FkComplianceItemContained)
                    .HasName("PLM4P_2222");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComplianceItemContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CompliesWith>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ComponentFunction>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ComStandardNutrientProperties>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Gsmid).IsUnicode(false);

                entity.Property(e => e.InFoodsId).IsUnicode(false);

                entity.Property(e => e.Unid).IsUnicode(false);
            });

            modelBuilder.Entity<ComStdNutrientPropertiesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkStandardNutrientProperties)
                    .HasName("PLM4P_2144");
            });

            modelBuilder.Entity<Constraints>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2249");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<CostItems>(entity =>
            {
                entity.HasIndex(e => e.FkCostMessage)
                    .HasName("PLM4P_2174");

                entity.HasIndex(e => new { e.Equivalent, e.FkScrmentity, e.FkCostMessage, e.EffectiveDate, e.CostType, e.FkLegacyProfile })
                    .HasName("CostItemsUniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CostMessages>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CostOptimizationConstraints>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<CostOptimizationObjectives>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Costs>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_1173");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.LangId).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CpFilters>(entity =>
            {
                entity.HasIndex(e => e.FkProfile)
                    .HasName("PLM4P_1161");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CpPortals>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CpProfiles>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CpViews>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FilterPluginLoader).IsUnicode(false);

                entity.Property(e => e.RenderingPluginLoader).IsUnicode(false);

                entity.Property(e => e.SearchPluginLoader).IsUnicode(false);
            });

            modelBuilder.Entity<CssAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CsseanpackageTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CsseanpackagingMaterialTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CsseanproductGroup>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cssgpcstatus>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CssInfoProvider>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssManufacturer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssPermissionTemplateItems>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3171");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PrimaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.PrimaryConditionParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionParams).IsUnicode(false);
            });

            modelBuilder.Entity<CssPermissionTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssPermissionTemplItemColls>(entity =>
            {
                entity.HasIndex(e => e.FkTemplate)
                    .HasName("PLM4P_3170");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssPublicationNamespace>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.InitialNonGhostActivity).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CssRetailer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssTargetMarket>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssTipOwners>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_FKOWNER");

                entity.HasIndex(e => e.FkTradeItemPublication)
                    .HasName("PLM4P_3168");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssTradeItemPublication>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssTradingPartnerNode>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3152");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.IsPhantom).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CssTradingPartnerNodeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CssTransaction>(entity =>
            {
                entity.HasIndex(e => e.FkTradeItemPublication)
                    .HasName("PLM4P_3157");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWfguardConditionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3161");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowActionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3159");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowActivityTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_3165");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowGroupMapTaxonomy>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowNameValueAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3162");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowProcessTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CssWorkflowStatuses>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<CssWorkflowTransitionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_3166");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CustomLookup>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<CustomNotifications>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DataAdminAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<DataAdminToolkitVersionHist>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DataExchangeVersionTracker>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.TypeQualifier).IsUnicode(false);
            });

            modelBuilder.Entity<DataGroup>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<DenormHdConfig>(entity =>
            {
                entity.Property(e => e.Name).ValueGeneratedNever();
            });

            modelBuilder.Entity<DenormHdHierarchyGsm>(entity =>
            {
                entity.HasIndex(e => e.FkAncestor)
                    .HasName("PLM4P_FI_FKANCESTOR_GSM");

                entity.HasIndex(e => e.FkDescendent)
                    .HasName("PLM4P_FI_FKDESCENDENT_GSM");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.LastEdit).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DenormHdHierarchyScrm>(entity =>
            {
                entity.HasIndex(e => e.FkAncestor)
                    .HasName("PLM4P_FI_FKANCESTOR_SCRM");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.LastEdit).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DenormHdRelationshipCtx>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DenormHdRelationshipCtxMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<DenormHdRequest>(entity =>
            {
                entity.Property(e => e.Pkid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastEdit).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Priority).HasDefaultValueSql("((100))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Densities>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_1028_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DrlApplicationDrlReference>(entity =>
            {
                entity.HasIndex(e => e.OwnerId)
                    .HasName("PLM4P_7505");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.OwningApplication).IsUnicode(false);
            });

            modelBuilder.Entity<DrlAttachment>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_7503");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DrlAttachmentReference>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2303_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DrlDocument>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DocumentNumber).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<DrlDocumentReference>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_2317");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DrlDocumentReferencesContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DrlDocumentTitleMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkDocument)
                    .HasName("PLM4P_7504");
            });

            modelBuilder.Entity<DwbAdditiveContainer>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5525");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbAllergenContainer>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5526");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbBreakdown>(entity =>
            {
                entity.HasIndex(e => e.FkDwbspecAttribute)
                    .HasName("PLM4P_5513");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbBreakdownSummary>(entity =>
            {
                entity.HasIndex(e => e.FkDwbspecAttribute)
                    .HasName("PLM4P_5533");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbExtendedAttribute>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5541");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbFormulationItems>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5500");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DerivedProductName).IsUnicode(false);
            });

            modelBuilder.Entity<DwbIntoleranceContainer>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5527");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbLioadjustments>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5523");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbLiocomponentReferences>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5522");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbLiogroups>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5521");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbLioitems>(entity =>
            {
                entity.HasIndex(e => e.FkContainer)
                    .HasName("PLM4P_5524");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbNutrient>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5503_1");

                entity.HasIndex(e => e.FkSupplementaryParent)
                    .HasName("PLM4P_5503_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Gsmid).IsUnicode(false);
            });

            modelBuilder.Entity<DwbOptimizationConstraint>(entity =>
            {
                entity.HasIndex(e => e.FkDwbspecification)
                    .HasName("PLM4P_5519");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbPackageConfigDo>(entity =>
            {
                entity.HasIndex(e => e.FkDwbspec)
                    .HasName("PLM4P_5520");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbPackagingMaterial>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5529");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbPossiblyCntnedAdditiveCntnr>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5539");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbPossiblyCntnedAllergenCntnr>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5538");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbPossiblyCntnedIntolCntnr>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5540");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbProfile>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbSpecAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkBasisParent)
                    .HasName("PLM4P_5501_1");

                entity.HasIndex(e => e.FkExperimentParent)
                    .HasName("PLM4P_5501_2");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5501_3");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkBasisParent).IsUnicode(false);

                entity.Property(e => e.FkExperimentParent).IsUnicode(false);
            });

            modelBuilder.Entity<DwbspecificationRoots>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5502");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbSpecifications>(entity =>
            {
                entity.HasIndex(e => e.FkSnapshotParent)
                    .HasName("PLM4P_5517");

                entity.HasIndex(e => e.FkWorkingVersionParent)
                    .HasName("PLM4P_5517_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.OptimizationObjectiveValue1).IsUnicode(false);

                entity.Property(e => e.OptimizationObjectiveValue2).IsUnicode(false);
            });

            modelBuilder.Entity<DwbSpecificationStep>(entity =>
            {
                entity.HasIndex(e => e.FkParentSpec)
                    .HasName("PLM4P_5518");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbspecStatus>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<DwbspecStatusMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpecStatus)
                    .HasName("PLM4P_5505");
            });

            modelBuilder.Entity<DwbSpecSubstitute>(entity =>
            {
                entity.HasIndex(e => e.FkContainer)
                    .HasName("PLM4P_5515");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EanuomEquivalent>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EatypeAllowedTargetSpecsMap>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqAdditive>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3010");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqAllergen>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3009");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqbreakdownContainer>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3022");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqCompliesWith>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3013");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqDrlDocsDo>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3020");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqIntolerances>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3011");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqItems>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3002");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkAffilatedDataObject).IsUnicode(false);

                entity.Property(e => e.SubOptions).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EqMarking>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqMarkingMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkEqmarking)
                    .HasName("PLM4P_3019");
            });

            modelBuilder.Entity<EqMatBreakdown>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3004");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Sequence).HasDefaultValueSql("((-1234567890))");
            });

            modelBuilder.Entity<EqMaterialQuestionnaire>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqModel>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqModelSection>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3012");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqNutrientItems>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3006");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqPackagingQuestionnaire>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqpackagingWastes>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3015");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqPrintedPkgingQuestionnaire>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqProductQuestionnaire>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqReassignEvents>(entity =>
            {
                entity.HasIndex(e => e.FkRequest)
                    .HasName("PLM4P_FK_5357");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqRequest>(entity =>
            {
                entity.HasIndex(e => e.FkCompanyOrFacility)
                    .HasName("PLM4P_3000_FKCOM");

                entity.HasIndex(e => e.FkSupplierContact)
                    .HasName("PLM4P_3000_CONTACT");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqrequestTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.QuestionaireType).IsUnicode(false);
            });

            modelBuilder.Entity<EqSourcingAttribute>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqSupportingDocs>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_3007");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqTradeQuestionnaire>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EqtsearchCriteria>(entity =>
            {
                entity.HasIndex(e => e.FkEqtsearchEntry)
                    .HasName("PLM4P_2213");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PropertyKey).IsUnicode(false);
            });

            modelBuilder.Entity<EqtsearchEntry>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FilterType).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);
            });

            modelBuilder.Entity<EquipmentInfoMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkEquipmentSpec)
                    .HasName("PLM4P_2268");
            });

            modelBuilder.Entity<ExtendedAttributeOptConstraint>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<ExtendedAttributeOptObjective>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ExtendedAttributesContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ExtendedAttributeTheoRollBeh>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_1176");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FclfoodGroup>(entity =>
            {
                entity.HasIndex(e => e.SourceId)
                    .HasName("PLM4P_5605");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FoodGroupId).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);
            });

            modelBuilder.Entity<FclfoodGroupMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFclfoodGroup)
                    .HasName("PLM4P_5606");
            });

            modelBuilder.Entity<FclfoodItem>(entity =>
            {
                entity.HasIndex(e => e.FkFclfoodGroup)
                    .HasName("PLM4P_5607");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FoodGroupId).IsUnicode(false);

                entity.Property(e => e.FoodItemId).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);
            });

            modelBuilder.Entity<FclfoodItemMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFclfoodItem)
                    .HasName("PLM4P_5608");
            });

            modelBuilder.Entity<FclfoodNutrientValue>(entity =>
            {
                entity.HasIndex(e => e.FkFclfoodItem)
                    .HasName("PLM4P_5603");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FoodItemId).IsUnicode(false);

                entity.Property(e => e.NutrientId).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);
            });

            modelBuilder.Entity<Fclnutrient>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.InFoodsId).IsUnicode(false);

                entity.Property(e => e.NutrientId).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);
            });

            modelBuilder.Entity<FclnutrientMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFclnutrient)
                    .HasName("PLM4P_5602");
            });

            modelBuilder.Entity<Fclsource>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.SourceId).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FicliodisclosureNameMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFicliodisclosure)
                    .HasName("PLM4P_6905");
            });

            modelBuilder.Entity<FicliodisclosureNotesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFicliodisclosure)
                    .HasName("PLM4P_6906");
            });

            modelBuilder.Entity<Ficliodisclosures>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FicTermAliases>(entity =>
            {
                entity.HasIndex(e => e.FkAliasParent)
                    .HasName("PLM4P_6901");

                entity.HasIndex(e => e.FkTermParent)
                    .HasName("PLM4P_6901_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkAliasParent).IsUnicode(false);

                entity.Property(e => e.FkTermParent).IsUnicode(false);
            });

            modelBuilder.Entity<FicTermAliasNamesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTermAlias)
                    .HasName("PLM4P_6902");
            });

            modelBuilder.Entity<FicTermAliasNotesMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTermAlias)
                    .HasName("PLM4P_6903");
            });

            modelBuilder.Entity<FicTerms>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.TermId).IsUnicode(false);
            });

            modelBuilder.Entity<FinishedPackagingSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FinishedProductBrand>(entity =>
            {
                entity.Property(e => e.Pkid).HasDefaultValueSql("('2036' + upper(newid()))");
            });

            modelBuilder.Entity<FinishedProductSpec>(entity =>
            {
                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_PKID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceAltMenuItemBuild>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_6506");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkOriginal).IsUnicode(false);
            });

            modelBuilder.Entity<FoodServiceDesignAttribute>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6511");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceFormulations>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceGlobalRegionalStd>(entity =>
            {
                entity.HasIndex(e => e.FkAlternate)
                    .HasName("PLM4P_6508_1");

                entity.HasIndex(e => e.FkStandard)
                    .HasName("PLM4P_6508_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceMenuItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceMenuItemBuild>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_6503");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceMenuItemClass>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<FoodServiceProduct>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceProductAttribute>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_6502");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceStandardType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FoodServiceStandardTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFoodServiceStandard)
                    .HasName("PLM4P_6509");
            });

            modelBuilder.Entity<FormSpecAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkExperimentParent)
                    .HasName("PLM4P_5858");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5858_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationClassificationMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFormulationClassification)
                    .HasName("PLM4P_1036");
            });

            modelBuilder.Entity<FormulationClassifications>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationCompostionMappings>(entity =>
            {
                entity.HasIndex(e => e.FkParentStep)
                    .HasName("PLM4P_5824");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationInputRatio>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5850");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationOutputOverrides>(entity =>
            {
                entity.HasIndex(e => e.FkParentOutput)
                    .HasName("PLM4P_5848");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationOutputSettings>(entity =>
            {
                entity.HasIndex(e => e.FkParentOutput)
                    .HasName("PLM4P_5849");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationSpecification>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<FormulationTheoreticalRollup>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5844");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GroupChangeRequestAction>(entity =>
            {
                entity.HasIndex(e => e.FkGroupChangeRequest)
                    .HasName("PLM4P_1163");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasIndex(e => e.FkGroup)
                    .HasName("PLM4P_2055");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GroupsMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkGroup)
                    .HasName("PLM4P_2298");
            });

            modelBuilder.Entity<GsmApprovedUsage>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_FKSPECID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmAssociatedSpec>(entity =>
            {
                entity.HasIndex(e => e.FkHost)
                    .HasName("PLM4P_1085_1");

                entity.HasIndex(e => e.FkTarget)
                    .HasName("PLM4P_1085_12");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmAssociationType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmAssociationTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAssociationType)
                    .HasName("PLM4P_5763");
            });

            modelBuilder.Entity<GsmAttributeRange>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2224");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmAttributeRangeGroupMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmAttributeRangeItemMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkRangeItem)
                    .HasName("PLM4P_2226");
            });

            modelBuilder.Entity<GsmBaseMaterialSubstitute>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmBaseSpecAttributesDo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmBaseTradeSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmBrandInformation>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2154");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmBrandInformationFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkBrandInformation)
                    .HasName("PLM4P_2153");
            });

            modelBuilder.Entity<GsmCombinedPackagingAlternates>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2164");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Annotation).IsUnicode(false);

                entity.Property(e => e.FkReplaces).IsUnicode(false);
            });

            modelBuilder.Entity<GsmCombinedPrintPkgingAlts>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2219");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Annotation).IsUnicode(false);

                entity.Property(e => e.FkReplaces).IsUnicode(false);
            });

            modelBuilder.Entity<GsmCupackagingAttributes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ContainerNetWeightUom).IsUnicode(false);

                entity.Property(e => e.LabelSizeWeightUom).IsUnicode(false);
            });

            modelBuilder.Entity<GsmCupackagingFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkPackagingAttribute)
                    .HasName("PLM4P_2120");
            });

            modelBuilder.Entity<GsmEanspecialConditions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmEquipmentSpecification>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmExtendedAttributeGroupMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmFormulaOutputType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulaOutputTypeMml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmFormulationInputs>(entity =>
            {
                entity.HasIndex(e => e.FkFormulationStep)
                    .HasName("PLM4P_5817");

                entity.HasIndex(e => e.FkMaterial)
                    .HasName("PLM4P_5817_fkMat");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationMaterials>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationOutput>(entity =>
            {
                entity.HasIndex(e => e.FkFormulationStep)
                    .HasName("PLM4P_5820");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationSpecAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkFormulationSnapshot)
                    .HasName("PLM4P_5835");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationSteps>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5818");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationSubMaterial>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5836");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmFormulationTypeMml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmFreeTextComment>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5753");
            });

            modelBuilder.Entity<GsmFsisapplication>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5786");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkParent).IsUnicode(false);
            });

            modelBuilder.Entity<GsmLabelClaim>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Pkid).HasDefaultValueSql("('5789' + upper(newid()))");

                entity.Property(e => e.LangId).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<GsmLabelCompositionProfile>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5784");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmLabelCompProfileItems>(entity =>
            {
                entity.HasIndex(e => e.FkProfile)
                    .HasName("PLM4P_5785");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmLabelOwner>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmLanguages>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmMatBreakdownDescFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkIngredientBreakdown)
                    .HasName("PLM4P_2187");
            });

            modelBuilder.Entity<GsmMatBreakdownExtDescFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkIngredientBreakdown)
                    .HasName("PLM4P_2230");
            });

            modelBuilder.Entity<GsmMaterialOriginalItem>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5778");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmMaterialSubstitute>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5776");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmMaterialSubstituteItem>(entity =>
            {
                entity.HasIndex(e => e.FkMaterial)
                    .HasName("PLM4P_5777_fkMat");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5777");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmMaterialType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmMaterialTypeMml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmNutrientComposite>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmNutrientCompositeItem>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5802");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmNutrientExtendedAttribute>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmNutrientItemNotesFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_2170");
            });

            modelBuilder.Entity<GsmNutrientProfile>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5750");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmNutrientProfileContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmNutritionalPanelItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmNutritionalPanelItemMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmOutputApproximateYield>(entity =>
            {
                entity.HasIndex(e => e.FkOutputItem)
                    .HasName("PLM4P_5821");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPackageType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPackageTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmPackageTypeMml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkPackageType)
                    .HasName("PLM4P_2158");
            });

            modelBuilder.Entity<GsmPackagingAttributeCoding>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5787");
            });

            modelBuilder.Entity<GsmPackagingAttributeCu>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2155");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPackagingAttributeTu>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2156");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPackagingLevel>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmPackagingMaterial>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2138");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPalletConfig>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmPalletType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmpermissionTemplateItems>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_6002");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PrimaryConditionParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionParams).IsUnicode(false);
            });

            modelBuilder.Entity<GsmpermissionTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmpermissionTemplItemColls>(entity =>
            {
                entity.HasIndex(e => e.FkTemplate)
                    .HasName("PLM4P_6001");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmPrintModelRows>(entity =>
            {
                entity.HasIndex(e => e.FkParentPrintModel)
                    .HasName("PLM4P_5797");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmProcessSpecPrintModel>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.WorksheetStyle).IsUnicode(false);
            });

            modelBuilder.Entity<GsmProductClassification>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2152");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmProductFactSheet>(entity =>
            {
                entity.HasIndex(e => e.FkSupportingDocument)
                    .HasName("PLM4P_5795");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmProductIdentification>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_2148");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmRelatedPackaging>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5791");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Annotation).IsUnicode(false);
            });

            modelBuilder.Entity<GsmRelatedPackagingAlternate>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5792");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Annotation).IsUnicode(false);

                entity.Property(e => e.FkReplaces).IsUnicode(false);

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GsmRelatedPackingConfig>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2292");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmServingLabelFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_5790");
            });

            modelBuilder.Entity<GsmShelfLives>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5761");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmShortNameMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpecSummary)
                    .HasName("PLM4P_5811");
            });

            modelBuilder.Entity<GsmSignatureDocOwners>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5770");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.OwnerId).IsUnicode(false);
            });

            modelBuilder.Entity<GsmSignatureDocs>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5769");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmSignatureDocWfauditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmSpecOwners>(entity =>
            {
                entity.HasIndex(e => e.FkSpecSummary)
                    .HasName("PLM4P_5765");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("PLM4P_OWNERID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmStepCalcTypeLookupItems>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.StepCalcObjectLoaderUrl).IsUnicode(false);

                entity.Property(e => e.StepCalcPath).IsUnicode(false);

                entity.Property(e => e.StepCalcPathUserKey).IsUnicode(false);
            });

            modelBuilder.Entity<GsmStepCalcTypeLookupItemsMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParentLookupItem)
                    .HasName("PLM4P_5829");
            });

            modelBuilder.Entity<GsmStorageReqrmtsTradeSpecs>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmsuccessionRequest>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmSyncWithItemMldo>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5773");
            });

            modelBuilder.Entity<GsmSyncWithItems>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTareWeight>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_1098");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTaxType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<GsmTemperatureRange>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5801");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmtempSigAuthorities>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTestMethod>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTestMethodMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTestMethod)
                    .HasName("PLM4P_5805");
            });

            modelBuilder.Entity<GsmTheoreticalYield>(entity =>
            {
                entity.HasIndex(e => e.FkProcessSheet)
                    .HasName("PLM4P_2168");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTpselectionFrequencyJoin>(entity =>
            {
                entity.HasIndex(e => e.FkTpanalyticalProperty)
                    .HasName("PLM4P_2124");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTradedUnit>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.CaseGrossWeightUom).IsUnicode(false);

                entity.Property(e => e.PalletWeightUom).IsUnicode(false);
            });

            modelBuilder.Entity<GsmTradedUnitProductType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTradedUnitProductTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTradedUnitProductType)
                    .HasName("PLM4P_5800");
            });

            modelBuilder.Entity<GsmTradeMaterialSpecRelation>(entity =>
            {
                entity.HasIndex(e => e.FkMaterialSpec)
                    .HasName("PLM4P_5826");

                entity.HasIndex(e => e.FkTradeSpec)
                    .HasName("PLM4P_5826_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTradeParentChildJoin>(entity =>
            {
                entity.HasIndex(e => e.FkChildSpec)
                    .HasName("PLM4P_2151_1");

                entity.HasIndex(e => e.FkParentSpec)
                    .HasName("PLM4P_2151_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTradeType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmTradeTypeMml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTradeType)
                    .HasName("PLM4P_2163");
            });

            modelBuilder.Entity<GsmTradingCompany>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmUdexclassification>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmVarietyTitleFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2123");
            });

            modelBuilder.Entity<GsmWfgaurdConditionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5759");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.GuardConditionInstanceFacUrl).IsUnicode(false);
            });

            modelBuilder.Entity<GsmWorkflowActionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5760");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmWorkflowActivityTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_5758");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmWorkflowGroupMapTaxonomy>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmWorkflowNameValueAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5764");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmWorkflowProcessTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmWorkflowTransitionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_5757");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<HtmlData>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2193");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<HtmlMarkup>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ImportRequestQueue>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.TargetSystem).IsUnicode(false);
            });

            modelBuilder.Entity<IngCombStatementsFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_FKSPECID")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<IngStatementFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_FKSPECID")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<IntoleranceContainedSourceMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkIntolerance)
                    .HasName("PLM4P_2183");
            });

            modelBuilder.Entity<Intolerances>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<IntolerancesContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2179");

                entity.HasIndex(e => new { e.FkParent, e.FkIntolerance })
                    .HasName("unq_intolerancescontained_fkparent_fkintolerance")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<IntolerancesPossiblyContained>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2261");

                entity.HasIndex(e => new { e.FkParent, e.FkIntolerance })
                    .HasName("unq_intolerancespossiblycontained_fkparent_fkintolerance")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<IssueTrackingItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LabelingSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LinearMeasure>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<LinearWorkflowConfigTokens>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2241");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LinearWorkflowWorkItemDo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lioannotations>(entity =>
            {
                entity.HasIndex(e => e.FkLioelement)
                    .HasName("PLM4P_5531");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LioauditHistoryItems>(entity =>
            {
                entity.HasIndex(e => e.FkLioroot)
                    .HasName("PLM4P_5535");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DisplayFormatId).IsUnicode(false);
            });

            modelBuilder.Entity<LiodisplayMessagePctThreshold>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<Lioelements>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DisplayFormatId).IsUnicode(false);
            });

            modelBuilder.Entity<LioelementSources>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5534");

                entity.HasIndex(e => e.FkSourceSpec)
                    .HasName("PLM4P_5534_fkSource");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LioprofileMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkLioprofile)
                    .HasName("PLM4P_5507");
            });

            modelBuilder.Entity<Lioprofiles>(entity =>
            {
                entity.HasIndex(e => e.FkTargetIngredient)
                    .HasName("PLM4P_5506_fkTarget");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lioroots>(entity =>
            {
                entity.HasIndex(e => e.FkDwbspec)
                    .HasName("PLM4P_5532");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.StatementFormat).IsUnicode(false);

                entity.Property(e => e.StatementStyle).IsUnicode(false);
            });

            modelBuilder.Entity<LiostatementStyleLookupItems>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<LsLabelClaimMldo>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkLabelClaim)
                    .HasName("PLM4P_4051");
            });

            modelBuilder.Entity<LsLabelClaimRules>(entity =>
            {
                entity.HasIndex(e => e.FkRuleset)
                    .HasName("PLM4P_4052");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LsLabelClaimRulesets>(entity =>
            {
                entity.HasIndex(e => e.FkLabelClaim)
                    .HasName("PLM4P_4053");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<LsLabelClaims>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DexVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LwfactivityOwnerConfigs>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<MandatoryProperty>(entity =>
            {
                entity.HasIndex(e => e.FkSearchableModel)
                    .HasName("PLM4P_6101");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PropertyName).IsUnicode(false);
            });

            modelBuilder.Entity<ManuManufacturerSummary>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<MasterSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<MaterialSpec>(entity =>
            {
                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_PKID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActDocumentCollaborations>(entity =>
            {
                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_FKACTIVITY");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActDocumentCollaborations2>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivities>(entity =>
            {
                entity.HasIndex(e => e.FkActivityTemplate)
                    .HasName("PLM4P_FKACTIVITYTEMPLATE");

                entity.HasIndex(e => e.FkCreator)
                    .HasName("PLM4P_FKCREATOR");

                entity.HasIndex(e => e.FkParent2)
                    .HasName("PLM4P_FKPARENT2");

                entity.HasIndex(e => e.FkProject)
                    .HasName("PLM4P_FKPROJECT");

                entity.HasIndex(e => e.FkRootActivity)
                    .HasName("PLM4P_FKROOTACTIVITY");

                entity.HasIndex(e => e.FkStatus)
                    .HasName("PLM4P_FKSTATUS");

                entity.HasIndex(e => e.FkWorkflowProcess)
                    .HasName("PLM4P_FKWORKFLOWPROCESS");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityAttachments>(entity =>
            {
                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_FKACTIVITY");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityImcfkcssection7s>(entity =>
            {
                entity.HasIndex(e => e.FkActivityImcf)
                    .HasName("PLM4P_3341");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_3226");
            });

            modelBuilder.Entity<NpdActivityPackageCopies>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityPackagingComponents>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityPostLaunchReviewMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkNpdactivityPostLaunchReview)
                    .HasName("PLM4P_3377");
            });

            modelBuilder.Entity<NpdActivityPostLaunchReviews>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityProcessMemorandums>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityProjectScheduleMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityProjectSchedule)
                    .HasName("PLM4P_FKACTIVITYPROJECTSCHEDULE");
            });

            modelBuilder.Entity<NpdActivityProjectSchedules>(entity =>
            {
                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_FKACTIVITY");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivitySections>(entity =>
            {
                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_3331");

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_FKOWNER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityStageMilestoneMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdActivityStageMilestones>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityTemplate)
                    .HasName("fk_ActivityTemplate");

                entity.HasIndex(e => new { e.Name, e.LangId, e.FkActivityTemplate })
                    .HasName("PLM4P_FKACTIVITYTEMPLATE_LANGID");
            });

            modelBuilder.Entity<NpdActivityTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkMasterActivityTemplate)
                    .HasName("PLM4P_FKMASTERACTIVITYTEMPLATE");

                entity.HasIndex(e => new { e.IsMarkedAsDeleted, e.IsPrivateCopy, e.Pkid })
                    .HasName("PLM4P_PKID_DELETED");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityTemplateStepMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityTemplateStep)
                    .HasName("PLM4P_3295");
            });

            modelBuilder.Entity<NpdActivityTemplateSteps>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3294");

                entity.HasIndex(e => e.FkPlmUserGroupContainer)
                    .HasName("PLM4P_FKPLMUSERGROUPCONTAINER");

                entity.HasIndex(e => e.StepNumber)
                    .HasName("PLM4P_STEPNUMBER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActivityTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityType)
                    .HasName("PLM4P_3220");
            });

            modelBuilder.Entity<NpdActivityTypePbolinks>(entity =>
            {
                entity.HasIndex(e => e.PbolinkDescriptorSetId)
                    .HasName("PLM4P_3381");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PbolinkDescriptorSetId).IsUnicode(false);
            });

            modelBuilder.Entity<NpdActivityTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.BusinessObjectType).IsUnicode(false);

                entity.Property(e => e.ConfigValues).IsUnicode(false);

                entity.Property(e => e.PbolinkDescriptorSetId).IsUnicode(false);
            });

            modelBuilder.Entity<NpdActProjectSummaryUpdates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActProjSchedCustMilestoneMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCustomMilestone)
                    .HasName("PLM4P_FKCUSTOMMILESTONE");
            });

            modelBuilder.Entity<NpdActProjSchedCustMilestones>(entity =>
            {
                entity.HasIndex(e => e.FkProjectSchedule)
                    .HasName("PLM4P_3230");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActTemplateAssociations>(entity =>
            {
                entity.HasIndex(e => e.FkActivityTemplate)
                    .HasName("PLM4P_FKACTIVITYTEMPLATE");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_FKPARENT");

                entity.HasIndex(e => e.FkParent2)
                    .HasName("PLM4P_FKPARENT2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdActTemplateStepTransitions>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3301");

                entity.HasIndex(e => e.FkTargetStep)
                    .HasName("PLM4P_FKTARGETSTEP");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdAnswers>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3227");

                entity.HasIndex(e => e.FkQuestion)
                    .HasName("PLM4P_FKQUESTION");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdAuditHistory>(entity =>
            {
                entity.HasIndex(e => e.DocumentId)
                    .HasName("PLM4P_DOCID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdAuditHistoryAssocUser>(entity =>
            {
                entity.HasIndex(e => e.FkAuditHistory)
                    .HasName("PLM4P_FKAUDITHISTORY");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdBrands>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdChannels>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdClaims>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdConsumerValuePerception>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdCopyCategories>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkCopyType)
                    .HasName("PLM4P_3388");
            });

            modelBuilder.Entity<NpdCopyTexts>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3389");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdCopyTypes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdDemographics>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdEnablingTech>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdEventHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdGlobalCategories>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdGlobalUnitSize>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3315");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdIdea>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdideaMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkIdea)
                    .HasName("PLM4P_3409");
            });

            modelBuilder.Entity<NpdIdeaOrigins>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdIdeaTemplate>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdIdeaTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkIdeaTemplate)
                    .HasName("PLM4P_3239");
            });

            modelBuilder.Entity<NpdMatrixGroups>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdMatrixItemMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkMatrixItem)
                    .HasName("PLM4P_3297");
            });

            modelBuilder.Entity<NpdMatrixItems>(entity =>
            {
                entity.HasIndex(e => e.FkAdditionalNotifyParent)
                    .HasName("PLM4P_FKADDITIONALNOTIFYPARENT");

                entity.HasIndex(e => e.FkSigRequestParent)
                    .HasName("PLM4P_3296_3");

                entity.HasIndex(e => new { e.FkOwnerParent, e.FkSigRequestParent, e.FkAdditionalNotifyParent })
                    .HasName("PLM4P_PARENT");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdMatrixRoles>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdMatrixUsers>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdNumberManager>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPackageCopies>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdpackageCopyMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkPackageCopy)
                    .HasName("PLM4P_3386");
            });

            modelBuilder.Entity<NpdPbolinkDescriptors>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.CaptionBuilderUrl).IsUnicode(false);

                entity.Property(e => e.EqtselectionViewName).IsUnicode(false);

                entity.Property(e => e.FeatureSets).IsUnicode(false);

                entity.Property(e => e.InfoRetrieverUrl).IsUnicode(false);

                entity.Property(e => e.PbotypeAndAppTranslationUrl).IsUnicode(false);

                entity.Property(e => e.PunchoutBuilderUrl).IsUnicode(false);
            });

            modelBuilder.Entity<NpdPbolinks>(entity =>
            {
                entity.HasIndex(e => e.FkEntity)
                    .HasName("PLM4P_3382");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPermissionTemplateItemCs>(entity =>
            {
                entity.HasIndex(e => e.FkTemplate)
                    .HasName("PLM4P_3292");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPermissionTemplateItems>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3291");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PrimaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.PrimaryConditionParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionParams).IsUnicode(false);
            });

            modelBuilder.Entity<NpdPermissionTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPortfolioFilters>(entity =>
            {
                entity.HasIndex(e => e.FkProjectPortfolio)
                    .HasName("PLM4P_3289");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.SubAttributeKey).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<NpdPortfolioLayoutDefinitions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPortfolioLayoutItems>(entity =>
            {
                entity.HasIndex(e => e.FkLayoutDefinition)
                    .HasName("PLM4P_3399");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ConfigValues).IsUnicode(false);

                entity.Property(e => e.LayoutItemRendererClass).IsUnicode(false);
            });

            modelBuilder.Entity<NpdPortfolioLayouts>(entity =>
            {
                entity.HasIndex(e => e.FkPortfolio)
                    .HasName("PLM4P_3398");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdPriorities>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdProjCustMilestoneDefaultMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProjCustomMilestoneDefault)
                    .HasName("PLM4P_3285");
            });

            modelBuilder.Entity<NpdProjCustomMilestoneDefault>(entity =>
            {
                entity.HasIndex(e => e.FkProjectMilestoneDefaults)
                    .HasName("PLM4P_3284");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdProjectMilestoneDefaults>(entity =>
            {
                entity.HasIndex(e => e.FkProjectTemplate)
                    .HasName("PLM4P_3283");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdProjectMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProject)
                    .HasName("PLM4P_3203");
            });

            modelBuilder.Entity<NpdProjectPortfolios>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdProjects>(entity =>
            {
                entity.HasIndex(e => e.StageNumber)
                    .HasName("PLM4P_STAGENUMBER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdProjectTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProjectTemplate)
                    .HasName("PLM4P_3201");
            });

            modelBuilder.Entity<NpdProjectTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkSnapshotParent).IsUnicode(false);
            });

            modelBuilder.Entity<NpdProjectTypes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdProjectVisibilities>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdQuestionDocumentTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestionDocumentTemplate)
                    .HasName("PLM4P_3363");
            });

            modelBuilder.Entity<NpdQuestionDocumentTemplates>(entity =>
            {
                entity.HasIndex(e => e.QuestionDocumentId)
                    .HasName("PLM4P_QUESTIONDOCUMENTID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdQuestionGroupTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestionGroupTemplate)
                    .HasName("PLM4P_3407");
            });

            modelBuilder.Entity<NpdQuestionGroupTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdQuestionMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestion)
                    .HasName("PLM4P_3408");
            });

            modelBuilder.Entity<NpdQuestions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdRisks>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdSignatureRequests>(entity =>
            {
                entity.HasIndex(e => e.OwningEntityPkid)
                    .HasName("PLM4P_3235");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStageMasterMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkStageMaster)
                    .HasName("PLM4P_3403");
            });

            modelBuilder.Entity<NpdStageMasters>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStageMasterStageMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkStageMasterStage)
                    .HasName("PLM4P_3401");
            });

            modelBuilder.Entity<NpdStageMasterStages>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStages>(entity =>
            {
                entity.HasIndex(e => e.FkProject)
                    .HasName("PLM4P_3219");

                entity.HasIndex(e => e.StageNumber)
                    .HasName("PLM4P_STAGENUMBER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStageTemplateMilestoneMl>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStageTemplateMilestones>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStageTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProjectTemplate)
                    .HasName("PLM4P_3207");

                entity.HasIndex(e => e.FkQuestionDocumentTemplate)
                    .HasName("PLM4P_FKQUESTIONDOCUMENTTEMPLATE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStrategicBriefMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProject)
                    .HasName("PLM4P_3210");
            });

            modelBuilder.Entity<NpdStrategicBriefs>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdStrategicBriefTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProjectTemplate)
                    .HasName("PLM4P_3206");
            });

            modelBuilder.Entity<NpdStrategicBriefTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdTeamMemberFormulationGroups>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3358");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdTeamMemberFormulationUsers>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3216");

                entity.HasIndex(e => e.FkUser)
                    .HasName("PLM4P_FKUSER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdTeamMembFormulationReqrmtMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTeamMemFormulationRqrmt)
                    .HasName("PLM4P_3215");
            });

            modelBuilder.Entity<NpdTeamMembFormulationReqrmts>(entity =>
            {
                entity.HasIndex(e => e.FkAdditionalOwner)
                    .HasName("PLM4P_FKADDITIONALOWNER");

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3214_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdTempSigAuthorities>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdToolboxEntry>(entity =>
            {
                entity.HasIndex(e => e.FkEntityAttachment)
                    .HasName("PLM4P_3406");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdWfguardConditionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3288");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.GuardConditionInstanceFacUrl).IsUnicode(false);
            });

            modelBuilder.Entity<NpdWorkflowActionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3286");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdWorkflowActivityTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_FKPROCESSTEMPLATE");

                entity.HasIndex(e => e.FkWorkflowStatus)
                    .HasName("PLM4P_FKWORKFLOWSTATUS");

                entity.HasIndex(e => e.Position)
                    .HasName("PLM4P_POSITION");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdWorkflowNameValueAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3287");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdWorkflowProcessTemplates>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("PLM4P_NAME");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NpdWorkflowStatuses>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<NpdWorkflowTransitionTemplates>(entity =>
            {
                entity.HasIndex(e => e.FkFromActivityTemplate)
                    .HasName("PLM4P_FKFROMACTIVITYTEMPLATE");

                entity.HasIndex(e => e.FkProcessTemplate)
                    .HasName("PLM4P_3282");

                entity.HasIndex(e => e.FkToActivityTemplate)
                    .HasName("PLM4P_FKTOACTIVITYTEMPLATE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NsmNutrientAnalysis>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("('9999-12-31 00:00:00.000')");

                entity.Property(e => e.ReceivedFromLab).HasDefaultValueSql("('9999-12-31 00:00:00.000')");

                entity.Property(e => e.SentToLab).HasDefaultValueSql("('9999-12-31 00:00:00.000')");
            });

            modelBuilder.Entity<NsmNutrientAnalysisMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAnalysis)
                    .HasName("PLM4P_6153");
            });

            modelBuilder.Entity<NsmNutrientComposite>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.CompositeNumber).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("('9999-12-31 00:00:00.000')");
            });

            modelBuilder.Entity<NsmNutrientCompositeItem>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_6151");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NsmNutrientCompositeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkComposite)
                    .HasName("PLM4P_6154");
            });

            modelBuilder.Entity<NutrientAnalysis>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NutrientOptConstraints>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<NutrientOptObjectives>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<NutritionalOrigin>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ObjectAssocationAttributes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttrName).IsUnicode(false);

                entity.Property(e => e.AttrValue).IsUnicode(false);
            });

            modelBuilder.Entity<ObjectNameLookupFactory>(entity =>
            {
                entity.Property(e => e.TypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ObjectTypeAvailability>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Extension).IsUnicode(false);
            });

            modelBuilder.Entity<OptimizationBomItems>(entity =>
            {
                entity.HasIndex(e => e.FkParentSession)
                    .HasName("PLM4P_5861");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<OptimizationSessions>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5860");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.OutputDistribution).IsUnicode(false);
            });

            modelBuilder.Entity<OrattributeMetaInfo>(entity =>
            {
                entity.HasIndex(e => e.FkOrclassMetaInfo)
                    .HasName("PLM4P_4003");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Attributetablename).IsUnicode(false);

                entity.Property(e => e.Propertyname).IsUnicode(false);
            });

            modelBuilder.Entity<Orclassmetainfo>(entity =>
            {
                entity.HasIndex(e => e.FkOrnamespaceMetaInfo)
                    .HasName("PLM4P_4000");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Classname).IsUnicode(false);

                entity.Property(e => e.ImplementedInterfaces).IsUnicode(false);

                entity.Property(e => e.KeyManager).IsUnicode(false);

                entity.Property(e => e.Tablename).IsUnicode(false);
            });

            modelBuilder.Entity<OrnamespaceMetaInfo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Assemblyname).IsUnicode(false);

                entity.Property(e => e.Enumname).IsUnicode(false);

                entity.Property(e => e.Namespace).IsUnicode(false);
            });

            modelBuilder.Entity<Orobjectassociationmetainfo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.DbfunctionName).IsUnicode(false);
            });

            modelBuilder.Entity<Orobjectpropertymetainfo>(entity =>
            {
                entity.HasIndex(e => e.FkOrclassMetaInfo)
                    .HasName("PLM4P_4001");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Mastercolumnname).IsUnicode(false);

                entity.Property(e => e.Propertyname).IsUnicode(false);

                entity.Property(e => e.Referencetype).IsUnicode(false);

                entity.Property(e => e.Slavepropertyname).IsUnicode(false);
            });

            modelBuilder.Entity<PackagingPreferences>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttrName).IsUnicode(false);

                entity.Property(e => e.FkAttrParentId).IsUnicode(false);
            });

            modelBuilder.Entity<PackagingSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PackingConfigurationSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PackingSpec>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PermissionConditionObjects>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ObjectUrl).IsUnicode(false);
            });

            modelBuilder.Entity<PermissionTemplateItemColls>(entity =>
            {
                entity.HasIndex(e => e.FkTemplate)
                    .HasName("PLM4P_5653");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PermissionTemplateItems>(entity =>
            {
                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_5652");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.PrimaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.PrimaryConditionParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionArgsParams).IsUnicode(false);

                entity.Property(e => e.SecondaryConditionParams).IsUnicode(false);
            });

            modelBuilder.Entity<PermissionTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PersistentQueueNumberManager>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlantInfo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmActivities>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3115");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmActivityAttachments>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmActivityMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivity)
                    .HasName("PLM4P_3120");
            });

            modelBuilder.Entity<PlmActivityTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityTemplate)
                    .HasName("PLM4P_3114");
            });

            modelBuilder.Entity<PlmActivityTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmActivityTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkActivityType)
                    .HasName("PLM4P_3112");
            });

            modelBuilder.Entity<PlmActivityTypes>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.BusinessObjectType).IsUnicode(false);

                entity.Property(e => e.ConfigValues).IsUnicode(false);
            });

            modelBuilder.Entity<PlmActTemplateAssociations>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3121_1");

                entity.HasIndex(e => e.FkParent2)
                    .HasName("PLM4P_3121_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmAnalyticMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAnalytic)
                    .HasName("PLM4P_3142");
            });

            modelBuilder.Entity<PlmAnalytics>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AggregationField).IsUnicode(false);
            });

            modelBuilder.Entity<PlmAnalyticSeries>(entity =>
            {
                entity.HasIndex(e => e.FkAnalytic)
                    .HasName("PLM4P_3141");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmAnswers>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<PlmFieldExchangeBases>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmFieldExchangeCategories>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmFieldExchangeDefinitionMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFieldExchangeDefinition)
                    .HasName("PLM4P_3135");
            });

            modelBuilder.Entity<PlmFieldExchangeDefinitions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Calculation).IsUnicode(false);

                entity.Property(e => e.DataType).IsUnicode(false);

                entity.Property(e => e.Tag).IsUnicode(false);
            });

            modelBuilder.Entity<PlmFieldExchangeDefModels>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmFieldExchangeFiscalYears>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmFieldExchangeGlobals>(entity =>
            {
                entity.HasIndex(e => e.ParentPkid)
                    .HasName("PLM4P_3137_1");

                entity.HasIndex(e => e.ProjectPkid)
                    .HasName("PLM4P_3137_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Tag).IsUnicode(false);
            });

            modelBuilder.Entity<PlmFieldExchangePhases>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmFieldExchangeUomlistMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFieldExchangeUomlist)
                    .HasName("PLM4P_3140");
            });

            modelBuilder.Entity<PlmFieldExchangeUomlists>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmFieldExchangeValues>(entity =>
            {
                entity.HasIndex(e => e.ActivityPkid)
                    .HasName("PLM4P_3136");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmFieldExchDefinitionModelMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkFieldExchangeDefinitionModel)
                    .HasName("PLM4P_3148");
            });

            modelBuilder.Entity<PlmFunctionalAreas>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmMultiPartAttachments>(entity =>
            {
                entity.HasIndex(e => e.FkEntityAttachments)
                    .HasName("PLM4P_3127");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmProjCustMilestoneDefaultDo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmProjCustMilestoneDefMldo>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkProjCustomMilestoneDefault)
                    .HasName("PLM4P_3128");
            });

            modelBuilder.Entity<PlmProjectTypes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmQuestionDocumentTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestionDocumentTemplate)
                    .HasName("PLM4P_3133");
            });

            modelBuilder.Entity<PlmQuestionDocumentTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmQuestionGroupTemplateMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestionGroupTemplate)
                    .HasName("PLM4P_3149");
            });

            modelBuilder.Entity<PlmQuestionGroupTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmQuestionMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkQuestion)
                    .HasName("PLM4P_3150");
            });

            modelBuilder.Entity<PlmQuestionRelations>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmQuestions>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmSignatureRequests>(entity =>
            {
                entity.HasIndex(e => e.OwningEntityPkid)
                    .HasName("PLM4P_3122");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmStageGateWorkflowStatuses>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmStages>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmStageTemplateMilestoneMl>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmStageTemplateMilestones>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmStageTemplates>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmTableQuestionCaptions>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<PlmTeamMemberFormulationGroups>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3132");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmTeamMemberFormulationUsers>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_3107");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmTeamMembFormulationReqrmtMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTeamMemFormulationRqrmt)
                    .HasName("PLM4P_3108");
            });

            modelBuilder.Entity<PlmTeamMembFormulationReqrmts>(entity =>
            {
                entity.HasIndex(e => e.FkAdditionalOwner)
                    .HasName("PLM4P_3106_1");

                entity.HasIndex(e => e.FkOwner)
                    .HasName("PLM4P_3106_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmTempSigAuthorities>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlmUserGroupContainers>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlufreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2149");
            });

            modelBuilder.Entity<PmaAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<PosfreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2150");
            });

            modelBuilder.Entity<PqmAudits>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PqmSummary>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pqsfactor>(entity =>
            {
                entity.HasIndex(e => e.FkSection)
                    .HasName("PLM4P_5269");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PqsfactorInstance>(entity =>
            {
                entity.HasIndex(e => e.FkSectionInstance)
                    .HasName("PLM4P_5259");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkSectionInstance).IsUnicode(false);
            });

            modelBuilder.Entity<PqsfactorOption>(entity =>
            {
                entity.HasIndex(e => e.FkFactor)
                    .HasName("PLM4P_5254");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkFactor).IsUnicode(false);
            });

            modelBuilder.Entity<PqsfactorTestingProtocolId>(entity =>
            {
                entity.HasIndex(e => e.FkFactor)
                    .HasName("PLM4P_5265");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pqssample>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PqssampleType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<Pqsscorecard>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5261_1");

                entity.HasIndex(e => e.FkSample)
                    .HasName("PLM4P_5261_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pqssection>(entity =>
            {
                entity.HasIndex(e => e.FkSection)
                    .HasName("PLM4P_5252_1");

                entity.HasIndex(e => e.FkTemplate)
                    .HasName("PLM4P_5252_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkSection).IsUnicode(false);

                entity.Property(e => e.FkTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<PqssectionInstance>(entity =>
            {
                entity.HasIndex(e => e.FkScorecard)
                    .HasName("PLM4P_5260_1");

                entity.HasIndex(e => e.FkSectionInstance)
                    .HasName("PLM4P_5260_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkScorecard).IsUnicode(false);

                entity.Property(e => e.FkSection).IsUnicode(false);

                entity.Property(e => e.FkSectionInstance).IsUnicode(false);
            });

            modelBuilder.Entity<Pqssession>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<PqssessionToSample>(entity =>
            {
                entity.HasIndex(e => e.FkSession)
                    .HasName("PLM4P_5272");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pqstemplate>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RaccproductCategory>(entity =>
            {
                entity.Property(e => e.Pkid).HasDefaultValueSql("('2250' + convert(char(36),newid()))");
            });

            modelBuilder.Entity<RatingObservations>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2242");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ReconEquivTargets>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_2311_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RefAmountsCustomarilyConsumed>(entity =>
            {
                entity.Property(e => e.Pkid).HasDefaultValueSql("('2251' + convert(char(36),newid()))");

                entity.Property(e => e.LabelStatement).IsUnicode(false);
            });

            modelBuilder.Entity<RegFsisapplication>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_4069");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RegFsisapplicationType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RegFsisapplicationTypeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkApplicationType)
                    .HasName("PLM4P_4071");
            });

            modelBuilder.Entity<RegRegulatoryAuth>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RegRegulatoryAuthMldo>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkRegulatoryAuth)
                    .HasName("PLM4P_4067");
            });

            modelBuilder.Entity<RegRegulatoryCategory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ReportRequest>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RichTextSupportingDoc>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2220_1");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RollupCosts>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmAddress>(entity =>
            {
                entity.HasIndex(e => e.City)
                    .HasName("PLM4P_CITY");

                entity.HasIndex(e => e.FkCountry)
                    .HasName("PLM4P_FKCOUNTRY");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5016");

                entity.HasIndex(e => e.PostalCode)
                    .HasName("PLM4P_POSTALCODE");

                entity.HasIndex(e => e.StateOrProvince)
                    .HasName("PLM4P_STATEPROVINCE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<ScrmCompany>(entity =>
            {
                entity.HasIndex(e => e.FkCountryId)
                    .HasName("PLM4P_SCRMCOMPANY_FKCOUNTRYID");

                entity.HasIndex(e => e.Fkstatus)
                    .HasName("PLM4P_SCRMCOMPANY_FKSTATUS");

                entity.HasIndex(e => e.Num)
                    .HasName("PLM4P_SCRMCOMPANY_NUMBER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmCompanySpecialAttributes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmContact>(entity =>
            {
                entity.HasIndex(e => e.Fkentity)
                    .HasName("PLM4P_5011");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmContactCategory>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmEntity>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmEntityFreeTextName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.Fkentity)
                    .HasName("PLM4P_PKID")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<ScrmEntityFreeTextNotes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.Langid })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkEntity)
                    .HasName("PLM4P_FKENTITY")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<ScrmEntityRelationship>(entity =>
            {
                entity.HasIndex(e => e.FkChild)
                    .HasName("PLM4P_CHILD");

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_PARENT")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmEntityStatBusRelationship>(entity =>
            {
                entity.HasIndex(e => e.FkEntity)
                    .HasName("PLM4P_5030");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmEntityStatus>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmFacility>(entity =>
            {
                entity.HasIndex(e => e.FkCompany)
                    .HasName("PLM4P_COMPANY")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.FkCountry)
                    .HasName("PLM4P_COUNTRY");

                entity.HasIndex(e => e.Fkstatus)
                    .HasName("PLM4P_STATUS");

                entity.HasIndex(e => e.Num)
                    .HasName("PLM4P_NUMBER");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmFacilitySpecialAttributes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmLegalAggreementMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkLegalAgreement)
                    .HasName("PLM4P_LEGALAGREEMENT")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<ScrmLegalAgreement>(entity =>
            {
                entity.HasIndex(e => e.FkEntityId)
                    .HasName("PLM4P_ENTITYID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmRelationshipType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmSignatureDocs>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5034");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmSourcingApproval>(entity =>
            {
                entity.HasIndex(e => e.FkFacilityId)
                    .HasName("PLM4P_ENTITYID")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.FkspecId)
                    .HasName("PLM4P_5012_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkProcessTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<ScrmSourcingApprovalBase>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmSourcingApprovalChecklist>(entity =>
            {
                entity.HasIndex(e => e.FkSourcingApproval)
                    .HasName("PLM4P_FKSOURCINGAPPROVAL")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmSourcingApprovalMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSourcingApproval)
                    .HasName("PLM4P_SOURCINGAPPROVAL")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<ScrmSourcingApprovalNonSpec>(entity =>
            {
                entity.HasIndex(e => e.FkFacilityId)
                    .HasName("PLM4P_FACILITY")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkProcessTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<ScrmSourcingType>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<ScrmSrcingApprChecklistItem>(entity =>
            {
                entity.HasIndex(e => e.FkSourcingApprovalChecklist)
                    .HasName("PLM4P_SACHECKLIST")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmsupplierBase>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmWorkflowAuditHistory>(entity =>
            {
                entity.HasIndex(e => e.DocumentId)
                    .HasName("PLM4P_DOCUMENTID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScrmWorkflowOwner>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5033");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.OwnerId).IsUnicode(false);
            });

            modelBuilder.Entity<SdmcommonLookupJoin>(entity =>
            {
                entity.HasKey(e => new { e.FkSdmpkid, e.FkCommonLookupPkid });
            });

            modelBuilder.Entity<SearchableModelColumnInfo>(entity =>
            {
                entity.HasIndex(e => e.FkSearchableModel)
                    .HasName("PLM4P_6100");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AggregationDelimiter).IsUnicode(false);

                entity.Property(e => e.DataField).IsUnicode(false);

                entity.Property(e => e.DataFieldCaption).IsUnicode(false);

                entity.Property(e => e.DataFormatter).IsUnicode(false);

                entity.Property(e => e.DataViewTransformationFactory).IsUnicode(false);
            });

            modelBuilder.Entity<SearchableModelInfo>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.DefaultCriteriaName).IsUnicode(false);

                entity.Property(e => e.ModelClassTypeId).IsUnicode(false);

                entity.Property(e => e.OrderBy).IsUnicode(false);

                entity.Property(e => e.PrimaryKeyColumnName).IsUnicode(false);
            });

            modelBuilder.Entity<SecuredObjectType>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SecurityAccessLevel>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SecurityClassification>(entity =>
            {
                entity.HasIndex(e => e.FkSecuredObjectType)
                    .HasName("PLM4P_5656");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SecurityMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5657");
            });

            modelBuilder.Entity<SecurityPrivilege>(entity =>
            {
                entity.HasIndex(e => e.FkGroup)
                    .HasName("PLM4P_5655");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ShelfLifeTypes>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<SmartIssueRequest>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SmartIssueRequestMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkRequest)
                    .HasName("PLM4P_5827");
            });

            modelBuilder.Entity<SpecActivitySpecification>(entity =>
            {
                entity.HasIndex(e => e.FkInitiatingSpec)
                    .HasName("PLM4P_2283");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecAnalyticalPropertyScoring>(entity =>
            {
                entity.HasIndex(e => e.FkTestingProtocolAnalytical)
                    .HasName("PLM4P_2109");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecAuditHistory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecAvailUomjoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_5823");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecClassificationAttr>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<SpecDescriptionFreeTextProp>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_FKSPECID")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<SpecImedPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecImedPrintPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2216");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecInnerPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecInnerPrintPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2217");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecLabelPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_1099");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecLabelPrintPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_1100");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecLegacyProfile>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecLegacySpecJoin>(entity =>
            {
                entity.HasIndex(e => e.FkLegacyProfileId)
                    .HasName("PLM4P_LEGACY");

                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecLineageHistory>(entity =>
            {
                entity.HasIndex(e => e.FkParticipantSpec)
                    .HasName("PLM4P_2320_1");

                entity.HasIndex(e => e.FkSourceSpec)
                    .HasName("PLM4P_2320_2");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecMatAttrFreeTextShipInst>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkIngredientAttributes)
                    .HasName("PLM4P_FKINGSPEC")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<SpecMatAttribFreeText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkIngredientAttributes)
                    .HasName("PLM4P_INGATTR")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<SpecMatAttribFreeTextRelaHum>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkIngredientAttributes)
                    .HasName("PLM4P_FKINGATTR")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<SpecMaterialAttributes>(entity =>
            {
                entity.HasIndex(e => e.FkIngredientSpec)
                    .HasName("PLM4P_FKINGSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Uom1).IsUnicode(false);

                entity.Property(e => e.Uom2).IsUnicode(false);

                entity.Property(e => e.Uom3).IsUnicode(false);
            });

            modelBuilder.Entity<SpecMaterialBreakdown>(entity =>
            {
                entity.HasIndex(e => e.FkBreakdown)
                    .HasName("PLM4P_FKBREAKDOWN")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.FkIngredientSpec)
                    .HasName("PLM4P_1013_fkIng");

                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_PKID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.FkIngredientSpec).IsUnicode(false);
            });

            modelBuilder.Entity<SpecOuterPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecOuterPrintPkgMaterialJoin>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_2218");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecPackagingPkgAttribute>(entity =>
            {
                entity.HasIndex(e => e.FkPackagingId)
                    .HasName("PLM4P_2045");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecPackagingWasteClass>(entity =>
            {
                entity.HasIndex(e => e.FkSpecId)
                    .HasName("PLM4P_2043");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecPkgingPkgAttrRelHumidity>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParentId)
                    .HasName("PLM4P_2087");
            });

            modelBuilder.Entity<SpecPkgingPkgAttrStorageInst>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkParentId)
                    .HasName("PLM4P_2088");
            });

            modelBuilder.Entity<SpecProcessPackagingAttribute>(entity =>
            {
                entity.HasIndex(e => e.FkProcessSheet)
                    .HasName("PLM4P_2038");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.CaseGrossWeightUom).IsUnicode(false);

                entity.Property(e => e.MaxNetWeightUom).IsUnicode(false);

                entity.Property(e => e.MinNetWeightUom).IsUnicode(false);
            });

            modelBuilder.Entity<SpecScoringMethod>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<SpecStorageRequirements>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<SpecSummary>(entity =>
            {
                entity.HasIndex(e => e.SpecId)
                    .HasName("PLM4P_SPECID");

                entity.HasIndex(e => e.SpecNumber)
                    .HasName("PLM4P_SPECNUMISSUENUM");

                entity.HasIndex(e => e.SpecType)
                    .HasName("PLM4P_SPECTYPE");

                entity.HasIndex(e => new { e.SpecNum, e.IssueNum })
                    .HasName("PLM4P_SPECSUMMARY");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.LangCreatedIn).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpecStatusId).IsUnicode(false);
            });

            modelBuilder.Entity<SpecSummaryName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.Langid })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecsummary)
                    .HasName("PLM4P_LANGSPECNAME")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.FkSpecsummary, e.Name, e.Langid })
                    .HasName("PLM4P_FK_SPECSUMMARYNAME");
            });

            modelBuilder.Entity<SpecSummaryReasonForChange>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkSpecSummary)
                    .HasName("PLM4P_FKSPECSUMMARY")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<SpecTestingProtocolSection>(entity =>
            {
                entity.HasIndex(e => e.FkTestingProtocol)
                    .HasName("PLM4P_2111");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecToOutputRatioOptConstraint>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<SpecToSpecRatioOptConstraint>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<SpecTpsectionFreeTextName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkTestingProtocolSection)
                    .HasName("PLM4P_2112");
            });

            modelBuilder.Entity<SpecUrcountries>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecUsageRestriction>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecUsageVariety>(entity =>
            {
                entity.HasIndex(e => e.FkFinishedProduct)
                    .HasName("PLM4P_FKFPSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpecWorkflowAuditHistory>(entity =>
            {
                entity.HasIndex(e => e.DocId)
                    .HasName("PLM4P_AUDITHISTORYBYDOCID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpEvents>(entity =>
            {
                entity.HasIndex(e => e.FkSupplierRep)
                    .HasName("PLM4P_5353");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpEventText>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<SpStatuses>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<SpSupplierReps>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ExternalId).IsUnicode(false);

                entity.Property(e => e.NotesPassword).IsUnicode(false);

                entity.Property(e => e.Passphrase).IsUnicode(false);

                entity.Property(e => e.PassphraseSalt).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PasswordHashAlgorithm).IsUnicode(false);

                entity.Property(e => e.PasswordSalt).IsUnicode(false);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SupplierInitiatedQuestionaire>(entity =>
            {
                entity.HasIndex(e => e.FkSac)
                    .HasName("PLM4P_5005");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<SupportingDocuments>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TableRenameLookup>(entity =>
            {
                entity.Property(e => e.OldName)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NewName).IsUnicode(false);
            });

            modelBuilder.Entity<TargetMarket>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Taxonomy>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TaxonomyTranslations>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TestingProtocol>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_FKSPEC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<TestingProtocolDescription>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkTestingProtocol)
                    .HasName("PLM4P_FKTESTINGPROTOCOL")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<TestingProtocolName>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkTestingProtocol)
                    .HasName("PLM4P_FKTESTINGPROTOCOL")
                    .ForSqlServerIsClustered();
            });

            modelBuilder.Entity<TestingProtocolsContainer>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestingProtocolScopeMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TestingProtocolSelection>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TestingProtocolStatusMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TestProtocolAnalyticalProperty>(entity =>
            {
                entity.HasIndex(e => e.FkTestingProtocolSection)
                    .HasName("PLM4P_2079_2");

                entity.HasIndex(e => new { e.Pkid, e.Sequence })
                    .HasName("PLM4P_PKIDSEQUENCE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestProtocolAnalytSpecLimits>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAnalyticalProperty)
                    .HasName("PLM4P_2098");
            });

            modelBuilder.Entity<TestProtocolAnalytTestUsed>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkAnalyticalProperty)
                    .HasName("PLM4P_2099");
            });

            modelBuilder.Entity<TheoreticalCalculation>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoreticalCompliance>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5845");

                entity.HasIndex(e => new { e.FkParent, e.Pkid })
                    .HasName("PLM4P_THEOCOMPLIANCE");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoreticalEnvWaste>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoreticalExtendedAttribute>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoreticalNutrition>(entity =>
            {
                entity.HasIndex(e => e.FkParent)
                    .HasName("PLM4P_5847");

                entity.HasIndex(e => new { e.FkParent, e.Pkid })
                    .HasName("PLM4P_THEONUTRITION");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoreticalSubcomponentAttr>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheoRollupCompliance>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TimeInterval>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TimeZones>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<TotalSolidsOptConstraint>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.Entity<TradePreferences>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.AttrName).IsUnicode(false);

                entity.Property(e => e.FkAttrParentId).IsUnicode(false);
            });

            modelBuilder.Entity<UgmChangeRequestEvent>(entity =>
            {
                entity.HasIndex(e => e.FkChangeRequest)
                    .HasName("PLM4P_2305");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<UgmGroupChangeRequest>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Unused1).IsUnicode(false);
            });

            modelBuilder.Entity<Uom>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Uomcategory>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.CategoryId).IsUnicode(false);
            });

            modelBuilder.Entity<UomcategoryMl>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkUomcategory)
                    .HasName("PLM4P_2287");
            });

            modelBuilder.Entity<Uomml>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });

                entity.HasIndex(e => e.FkUom)
                    .HasName("PLM4P_2126");
            });

            modelBuilder.Entity<UomnamedLists>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Urlsource>(entity =>
            {
                entity.HasIndex(e => e.FkSpec)
                    .HasName("PLM4P_1179");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.Urlpath).IsUnicode(false);
            });

            modelBuilder.Entity<UserAvailableLanguage>(entity =>
            {
                entity.HasIndex(e => e.FkUser)
                    .HasName("PLM4P_1080");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserChangeRequestAction>(entity =>
            {
                entity.HasIndex(e => e.FkUserChangeRequest)
                    .HasName("PLM4P_1164");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserEdit>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ExternalId).IsUnicode(false);

                entity.Property(e => e.Notespassword).IsUnicode(false);

                entity.Property(e => e.Passphrase).IsUnicode(false);

                entity.Property(e => e.PassphraseSalt).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PasswordHashAlgorithm).IsUnicode(false);

                entity.Property(e => e.PasswordSalt).IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("PLM4P_USERNAME");

                entity.Property(e => e.Pkid).ValueGeneratedNever();

                entity.Property(e => e.ExternalId).IsUnicode(false);

                entity.Property(e => e.Notespassword)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Passphrase).IsUnicode(false);

                entity.Property(e => e.PassphraseSalt).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PasswordHashAlgorithm).IsUnicode(false);

                entity.Property(e => e.PasswordSalt).IsUnicode(false);

                entity.Property(e => e.SingleTranslationEditing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Status).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<UserScrmpreference>(entity =>
            {
                entity.HasIndex(e => e.FkUser)
                    .HasName("PLM4P_FK_1266");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WasteMaterialClass>(entity =>
            {
                entity.HasKey(e => new { e.Pkid, e.LangId });
            });

            modelBuilder.Entity<WfadminRegisteredItem>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowAssignedResources>(entity =>
            {
                entity.HasIndex(e => e.FkActivityInstance)
                    .HasName("PLM4P_FKACTIVITYINSTANCE");

                entity.HasIndex(e => e.ResourceId)
                    .HasName("PLM4P_RESOURCEID");

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowGroupMapTaxonomy>(entity =>
            {
                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowResource>(entity =>
            {
                entity.HasIndex(e => e.FkActivityTemplate)
                    .HasName("PLM4P_ACTRESFKEY")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Pkid)
                    .HasName("PLM4P_RSOURCPKY")
                    .IsUnique();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowTransitionResource>(entity =>
            {
                entity.HasIndex(e => e.FkTransitionData)
                    .HasName("PLM4P_TRANSPARENT")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Pkid).ValueGeneratedNever();
            });
        }
    }
}
