using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Shapes;
using UIA = System.Windows.Automation;
using FlaUIRecorder.Tests.Common.Converters;
using FlaUI.UIA2.Extensions;
using FlaUIRecorder.Tests.Common.EventHandlers;

namespace FlaUIRecorder.Tests.Common
{
    public class TestBasicAutomationElement : BasicAutomationElementBase
    {
        //public TestBasicAutomationElement(AutomationBase automation) : base(automation)
        //{
        //}

        public TestBasicAutomationElement(TestAutomation automation, UIA.AutomationElement nativeElement) : this(automation, new TestAutomationElement(nativeElement))
        {
        }


        public TestBasicAutomationElement(TestAutomation automation, TestAutomationElement nativeElement) : base(automation)
        {
            Automation = automation;
            NativeElement = nativeElement;
            Patterns = new TestAutomationElementPatternValues(this);
        }

        /// <summary>
        /// Concrete implementation of the automation object
        /// </summary>
        public new TestAutomation Automation { get; }

        /// <summary>
        /// Native object for the ui element
        /// </summary>
        public TestAutomationElement NativeElement { get; }

        public override AutomationElementPatternValuesBase Patterns
        {
            get;
        }

        public override void SetFocus()
        {
            //NativeElement.SetFocus();
        }

        protected override object InternalGetPropertyValue(int propertyId, bool cached, bool useDefaultIfNotSupported)
        {
            var property = UIA.AutomationProperty.LookupById(propertyId);
            var ignoreDefaultValue = !useDefaultIfNotSupported;
            //var returnValue = cached ?
            //    NativeElement.GetCachedPropertyValue(property, ignoreDefaultValue) :
            //    NativeElement.GetCurrentPropertyValue(property, ignoreDefaultValue);
            //return returnValue;
            return NativeElement.GetPropertyValue(property, ignoreDefaultValue);
        }

        protected override object InternalGetPattern(int patternId, bool cached)
        {
            var pattern = UIA.AutomationPattern.LookupById(patternId);
            //var returnedValue = cached
            //    ? NativeElement.GetCachedPattern(pattern)
            //    : NativeElement.GetCurrentPattern(pattern);
            return NativeElement.GetPattern(pattern);
            //return returnedValue;
        }

        /// <inheritdoc />
        public override AutomationElement[] FindAll(TreeScope treeScope, ConditionBase condition)
        {
            throw new NotImplementedException();
            //var cacheRequest = CacheRequest.IsCachingActive ? CacheRequest.Current.ToNative() : null;
            //cacheRequest?.Push();
            //var nativeFoundElements = NativeElement.FindAll((UIA.TreeScope)treeScope, FlaUI.UIA2.Converters.ConditionConverter.ToNative(condition));
            //cacheRequest?.Pop();
            //return AutomationElementConverter.NativeArrayToManaged(Automation, nativeFoundElements);
        }

        /// <inheritdoc />
        public override AutomationElement FindFirst(TreeScope treeScope, ConditionBase condition)
        {
            throw new NotImplementedException();
            //var cacheRequest = CacheRequest.IsCachingActive ? CacheRequest.Current.ToNative() : null;
            //cacheRequest?.Push();
            //var nativeFoundElement = NativeElement.FindFirst((UIA.TreeScope)treeScope, FlaUI.UIA2.Converters.ConditionConverter.ToNative(condition));
            //cacheRequest?.Pop();
            //return AutomationElementConverter.NativeToManaged(Automation, nativeFoundElement);
        }

        /// <inheritdoc />
        //public override AutomationElement FindIndexed(TreeScope treeScope, int index, ConditionBase condition)
        //{
        //    var cacheRequest = CacheRequest.IsCachingActive ? CacheRequest.Current.ToNative() : null;
        //    cacheRequest?.Push();
        //    var nativeFoundElements = NativeElement.FindAll((UIA.TreeScope)treeScope, FlaUI.UIA2.Converters.ConditionConverter.ToNative(condition));
        //    cacheRequest?.Pop();
        //    var nativeElement = nativeFoundElements.Count > index ? nativeFoundElements[index] : null;
        //    return nativeElement == null ? null : AutomationElementConverter.NativeToManaged(Automation, nativeElement);
        //}

        public override bool TryGetClickablePoint(out Point point)
        {
            throw new NotImplementedException();
            //var success = NativeElement.TryGetClickablePoint(out System.Windows.Point outPoint);
            //if (success)
            //{
            //    point = new Point(outPoint.X, outPoint.Y);
            //}
            //else
            //{
            //    success = Properties.ClickablePoint.TryGetValue(out point);
            //}
            //return success;
        }

        public override IAutomationEventHandler RegisterEvent(EventId @event, TreeScope treeScope, Action<AutomationElement, EventId> action)
        {
            throw new NotImplementedException();
            //var eventHandler = new TestBasicEventHandler(Automation, action);
            //UIA.Automation.AddAutomationEventHandler(UIA.AutomationEvent.LookupById(@event.Id), NativeElement, (UIA.TreeScope)treeScope, eventHandler.EventHandler);
            //return eventHandler;
        }

        public override IAutomationPropertyChangedEventHandler RegisterPropertyChangedEvent(TreeScope treeScope, Action<AutomationElement, PropertyId, object> action, PropertyId[] properties)
        {
            throw new NotImplementedException();
            //var eventHandler = new TestPropertyChangedEventHandler(Automation, action);
            //UIA.Automation.AddAutomationPropertyChangedEventHandler(NativeElement, (UIA.TreeScope)treeScope, eventHandler.EventHandler);
            //return eventHandler;
        }

        public override IAutomationStructureChangedEventHandler RegisterStructureChangedEvent(TreeScope treeScope, Action<AutomationElement, StructureChangeType, int[]> action)
        {
            throw new NotImplementedException();
            //var eventHandler = new TestStructureChangedEventHandler(Automation, action);
            //UIA.Automation.AddStructureChangedEventHandler(NativeElement, (UIA.TreeScope)treeScope, eventHandler.EventHandler);
            //return eventHandler;
        }

        public override void RemoveAutomationEventHandler(EventId @event, IAutomationEventHandler eventHandler)
        {
            throw new NotImplementedException();
            //UIA.Automation.RemoveAutomationEventHandler(UIA.AutomationEvent.LookupById(@event.Id), NativeElement, ((TestBasicEventHandler)eventHandler).EventHandler);
        }

        public override void RemovePropertyChangedEventHandler(IAutomationPropertyChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
            //UIA.Automation.RemoveAutomationPropertyChangedEventHandler(NativeElement, ((TestPropertyChangedEventHandler)eventHandler).EventHandler);
        }

        public override void RemoveStructureChangedEventHandler(IAutomationStructureChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
            //UIA.Automation.RemoveStructureChangedEventHandler(NativeElement, ((TestStructureChangedEventHandler)eventHandler).EventHandler);
        }

        public override PatternId[] GetSupportedPatterns()
        {
            throw new NotImplementedException();
            //var raw = NativeElement.GetSupportedPatterns();
            //return raw.Select(r => PatternId.Find(Automation.AutomationType, r.Id)).ToArray();
        }

        public override PropertyId[] GetSupportedProperties()
        {
            throw new NotImplementedException();
            //var raw = NativeElement.GetSupportedProperties();
            //return raw.Select(r => PropertyId.Find(Automation.AutomationType, r.Id)).ToArray();
        }

        public override AutomationElement GetUpdatedCache()
        {
            throw new NotImplementedException();
            //if (CacheRequest.Current != null)
            //{
            //    var updatedElement = NativeElement.GetUpdatedCache(CacheRequest.Current.ToNative());
            //    return AutomationElementConverter.NativeToManaged(Automation, updatedElement);
            //}
            //return null;
        }

        public override AutomationElement[] GetCachedChildren()
        {
            throw new NotImplementedException();

            //var cachedChildren = NativeElement.CachedChildren;
            //return AutomationElementConverter.NativeArrayToManaged(Automation, cachedChildren);
        }

        public override AutomationElement GetCachedParent()
        {
            throw new NotImplementedException();
            //var cachedParent = NativeElement.CachedParent;
            //return AutomationElementConverter.NativeToManaged(Automation, cachedParent);
        }

        public override int GetHashCode()
        {
            return NativeElement.GetHashCode();
        }
    }
}
