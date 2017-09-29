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
    public class TestAutomationElementProperties : IAutomationElementProperties
    {
        public PropertyId AcceleratorKey => PropertyId.NotSupportedByFramework; //AutomationObjectIds.AcceleratorKeyProperty;
        public PropertyId AccessKey => PropertyId.NotSupportedByFramework; //AutomationObjectIds.AccessKeyProperty;
        public PropertyId AriaProperties => PropertyId.NotSupportedByFramework;
        public PropertyId AriaRole => PropertyId.NotSupportedByFramework;
        public PropertyId AutomationId => AutomationObjectIds.AutomationIdProperty;
        public PropertyId BoundingRectangle => PropertyId.NotSupportedByFramework; //AutomationObjectIds.BoundingRectangleProperty;
        public PropertyId ClassName => AutomationObjectIds.ClassNameProperty;
        public PropertyId ClickablePoint => PropertyId.NotSupportedByFramework; //AutomationObjectIds.ClickablePointProperty;
        public PropertyId ControllerFor => PropertyId.NotSupportedByFramework;
        public PropertyId ControlType => AutomationObjectIds.ControlTypeProperty;
        public PropertyId Culture => PropertyId.NotSupportedByFramework; //AutomationObjectIds.CultureProperty;
        public PropertyId DescribedBy => PropertyId.NotSupportedByFramework;
        public PropertyId FlowsFrom => PropertyId.NotSupportedByFramework;
        public PropertyId FlowsTo => PropertyId.NotSupportedByFramework;
        public PropertyId FrameworkId => PropertyId.NotSupportedByFramework; //AutomationObjectIds.FrameworkIdProperty;
        public PropertyId HasKeyboardFocus => PropertyId.NotSupportedByFramework; //AutomationObjectIds.HasKeyboardFocusProperty;
        public PropertyId HelpText => PropertyId.NotSupportedByFramework; //AutomationObjectIds.HelpTextProperty;
        public PropertyId IsContentElement => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsContentElementProperty;
        public PropertyId IsControlElement => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsControlElementProperty;
        public PropertyId IsDataValidForForm => PropertyId.NotSupportedByFramework;
        public PropertyId IsEnabled => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsEnabledProperty;
        public PropertyId IsKeyboardFocusable => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsKeyboardFocusableProperty;
        public PropertyId IsOffscreen => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsOffscreenProperty;
        public PropertyId IsPassword => AutomationObjectIds.IsPasswordProperty;
        public PropertyId IsPeripheral => PropertyId.NotSupportedByFramework;
        public PropertyId IsRequiredForForm => PropertyId.NotSupportedByFramework; //AutomationObjectIds.IsRequiredForFormProperty;
        public PropertyId ItemStatus => PropertyId.NotSupportedByFramework; //AutomationObjectIds.ItemStatusProperty;
        public PropertyId ItemType => PropertyId.NotSupportedByFramework; //AutomationObjectIds.ItemTypeProperty;
        public PropertyId LabeledBy => PropertyId.NotSupportedByFramework; //AutomationObjectIds.AcceleratorKeyProperty;
        public PropertyId LiveSetting => PropertyId.NotSupportedByFramework;
        public PropertyId LocalizedControlType => PropertyId.NotSupportedByFramework; //AutomationObjectIds.LocalizedControlTypeProperty;
        public PropertyId Name => AutomationObjectIds.NameProperty;
        public PropertyId NativeWindowHandle => PropertyId.NotSupportedByFramework; //AutomationObjectIds.NativeWindowHandleProperty;
        public PropertyId OptimizeForVisualContent => PropertyId.NotSupportedByFramework;
        public PropertyId Orientation => PropertyId.NotSupportedByFramework; //AutomationObjectIds.OrientationProperty;
        public PropertyId ProcessId => PropertyId.NotSupportedByFramework; //AutomationObjectIds.ProcessIdProperty;
        public PropertyId ProviderDescription => PropertyId.NotSupportedByFramework;
        public PropertyId RuntimeId => PropertyId.NotSupportedByFramework; //AutomationObjectIds.RuntimeIdProperty;
    }
}
