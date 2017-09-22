using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.UIA2.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Tests.Common
{

    public class TestAutomationElementPatternAvailabilityProperties : IAutomationElementPatternAvailabilityProperties
    {
        public PropertyId IsAnnotationPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsDockPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsDockPatternAvailableProperty;
        public PropertyId IsDragPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsDropTargetPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsExpandCollapsePatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsExpandCollapsePatternAvailableProperty;
        public PropertyId IsGridItemPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsGridItemPatternAvailableProperty;
        public PropertyId IsGridPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsGridPatternAvailableProperty;
        public PropertyId IsInvokePatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsInvokePatternAvailableProperty;
#if NET35
        public PropertyId IsItemContainerPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsItemContainerPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsItemContainerPatternAvailableProperty;
#endif
        public PropertyId IsLegacyIAccessiblePatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsMultipleViewPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsMultipleViewPatternAvailableProperty;
        public PropertyId IsObjectModelPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsRangeValuePatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsRangeValuePatternAvailableProperty;
        public PropertyId IsScrollItemPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsScrollItemPatternAvailableProperty;
        public PropertyId IsScrollPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsScrollPatternAvailableProperty;
        public PropertyId IsSelectionItemPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsSelectionItemPatternAvailableProperty;
        public PropertyId IsSelectionPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsSelectionPatternAvailableProperty;
        public PropertyId IsSpreadsheetPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsSpreadsheetItemPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsStylesPatternAvailable => PropertyId.NotSupportedByFramework;
#if NET35
        public PropertyId IsSynchronizedInputPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsSynchronizedInputPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsSynchronizedInputPatternAvailableProperty;
#endif
        public PropertyId IsTableItemPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsTableItemPatternAvailableProperty;
        public PropertyId IsTablePatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsTablePatternAvailableProperty;
        public PropertyId IsTextChildPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsTextEditPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsTextPatternAvailable => AutomationObjectIds.IsTextPatternAvailableProperty;
        public PropertyId IsTextPattern2Available => PropertyId.NotSupportedByFramework;
        public PropertyId IsTogglePatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsTogglePatternAvailableProperty;
        public PropertyId IsTransformPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsTransformPatternAvailableProperty;
        public PropertyId IsTransformPattern2Available => PropertyId.NotSupportedByFramework;
        public PropertyId IsValuePatternAvailable => AutomationObjectIds.IsValuePatternAvailableProperty;
#if NET35
        public PropertyId IsVirtualizedItemPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsVirtualizedItemPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsVirtualizedItemPatternAvailableProperty;
#endif
        public PropertyId IsWindowPatternAvailable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsWindowPatternAvailableProperty;

        public PropertyId[] AllForCurrentFramework => new[] {
            IsDockPatternAvailable,
            IsExpandCollapsePatternAvailable,
            IsGridItemPatternAvailable,
            IsGridPatternAvailable,
            IsInvokePatternAvailable,
#if !NET35
            IsItemContainerPatternAvailable,
#endif
            IsMultipleViewPatternAvailable,
            IsRangeValuePatternAvailable,
            IsScrollItemPatternAvailable,
            IsScrollPatternAvailable,
            IsSelectionItemPatternAvailable,
            IsSelectionPatternAvailable,
#if !NET35
            IsSynchronizedInputPatternAvailable,
#endif
            IsTableItemPatternAvailable,
            IsTablePatternAvailable,
            IsTextPatternAvailable,
            IsTogglePatternAvailable,
            IsTransformPatternAvailable,
            IsValuePatternAvailable,
#if !NET35
            IsVirtualizedItemPatternAvailable,
#endif
            IsWindowPatternAvailable
        };
    }
}
