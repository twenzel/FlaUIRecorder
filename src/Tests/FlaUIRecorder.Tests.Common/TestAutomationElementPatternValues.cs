using FlaUI.Core;
using FlaUI.Core.Exceptions;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUIRecorder.Tests.Common.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common
{
    public class TestAutomationElementPatternValues : AutomationElementPatternValuesBase
    {
        public TestAutomationElementPatternValues(TestBasicAutomationElement basicAutomationElement) : base(basicAutomationElement)
        {
        }

        protected override IAutomationPattern<IAnnotationPattern> InitializeAnnotationPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IDockPattern> InitializeDockPattern()
        {
            //return new AutomationPattern<IDockPattern, UIA.DockPattern>(
            //    DockPattern.Pattern, BasicAutomationElement, (b, p) => new DockPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IDragPattern> InitializeDragPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IDropTargetPattern> InitializeDropTargetPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IExpandCollapsePattern> InitializeExpandCollapsePattern()
        {
            //return new AutomationPattern<IExpandCollapsePattern, UIA.ExpandCollapsePattern>(
            //    ExpandCollapsePattern.Pattern, BasicAutomationElement, (b, p) => new ExpandCollapsePattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IGridItemPattern> InitializeGridItemPattern()
        {
            //return new AutomationPattern<IGridItemPattern, UIA.GridItemPattern>(
            //    GridItemPattern.Pattern, BasicAutomationElement, (b, p) => new GridItemPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IGridPattern> InitializeGridPattern()
        {
            //return new AutomationPattern<IGridPattern, UIA.GridPattern>(
            //     GridPattern.Pattern, BasicAutomationElement, (b, p) => new GridPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IInvokePattern> InitializeInvokePattern()
        {
            //return new AutomationPattern<IInvokePattern, UIA.InvokePattern>(
            //    InvokePattern.Pattern, BasicAutomationElement, (b, p) => new InvokePattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IItemContainerPattern> InitializeItemContainerPattern()
        {
            //#if NET35
            //            throw new NotSupportedByFrameworkException();
            //#else
            //            return new AutomationPattern<IItemContainerPattern, UIA.ItemContainerPattern>(
            //                ItemContainerPattern.Pattern, BasicAutomationElement, (b, p) => new ItemContainerPattern(b, p));
            //#endif
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ILegacyIAccessiblePattern> InitializeLegacyIAccessiblePattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IMultipleViewPattern> InitializeMultipleViewPattern()
        {
            //return new AutomationPattern<IMultipleViewPattern, UIA.MultipleViewPattern>(
            //    MultipleViewPattern.Pattern, BasicAutomationElement, (b, p) => new MultipleViewPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IObjectModelPattern> InitializeObjectModelPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IRangeValuePattern> InitializeRangeValuePattern()
        {
            //return new AutomationPattern<IRangeValuePattern, UIA.RangeValuePattern>(
            //    RangeValuePattern.Pattern, BasicAutomationElement, (b, p) => new RangeValuePattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IScrollItemPattern> InitializeScrollItemPattern()
        {
            //return new AutomationPattern<IScrollItemPattern, UIA.ScrollItemPattern>(
            //    ScrollItemPattern.Pattern, BasicAutomationElement, (b, p) => new ScrollItemPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IScrollPattern> InitializeScrollPattern()
        {
            //return new AutomationPattern<IScrollPattern, UIA.ScrollPattern>(
            //    ScrollPattern.Pattern, BasicAutomationElement, (b, p) => new ScrollPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISelectionItemPattern> InitializeSelectionItemPattern()
        {
            //return new AutomationPattern<ISelectionItemPattern, UIA.SelectionItemPattern>(
            //    SelectionItemPattern.Pattern, BasicAutomationElement, (b, p) => new SelectionItemPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISelectionPattern> InitializeSelectionPattern()
        {
            //return new AutomationPattern<ISelectionPattern, UIA.SelectionPattern>(
            //    SelectionPattern.Pattern, BasicAutomationElement, (b, p) => new SelectionPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISpreadsheetItemPattern> InitializeSpreadsheetItemPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISpreadsheetPattern> InitializeSpreadsheetPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IStylesPattern> InitializeStylesPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISynchronizedInputPattern> InitializeSynchronizedInputPattern()
        {
            //#if NET35
            //            throw new NotSupportedByFrameworkException();
            //#else
            //            return new AutomationPattern<ISynchronizedInputPattern, UIA.SynchronizedInputPattern>(
            //                SynchronizedInputPattern.Pattern, BasicAutomationElement, (b, p) => new SynchronizedInputPattern(b, p));
            //#endif
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITableItemPattern> InitializeTableItemPattern()
        {
            //return new AutomationPattern<ITableItemPattern, UIA.TableItemPattern>(
            //    TableItemPattern.Pattern, BasicAutomationElement, (b, p) => new TableItemPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITablePattern> InitializeTablePattern()
        {
            //return new AutomationPattern<ITablePattern, UIA.TablePattern>(
            //    TablePattern.Pattern, BasicAutomationElement, (b, p) => new TablePattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITextChildPattern> InitializeTextChildPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITextEditPattern> InitializeTextEditPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IText2Pattern> InitializeText2Pattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITextPattern> InitializeTextPattern()
        {
            return new AutomationPattern<ITextPattern, NativeTextPattern>(
                TextPattern.Pattern, BasicAutomationElement, (b, p) => new TextPattern(b, p));
        }

        protected override IAutomationPattern<ITogglePattern> InitializeTogglePattern()
        {
            //return new AutomationPattern<ITogglePattern, UIA.TogglePattern>(
            //    TogglePattern.Pattern, BasicAutomationElement, (b, p) => new TogglePattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITransform2Pattern> InitializeTransform2Pattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITransformPattern> InitializeTransformPattern()
        {
            //return new AutomationPattern<ITransformPattern, UIA.TransformPattern>(
            //    TransformPattern.Pattern, BasicAutomationElement, (b, p) => new TransformPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IValuePattern> InitializeValuePattern()
        {
            return new AutomationPattern<IValuePattern, NativeValuePattern>(
                ValuePattern.Pattern, BasicAutomationElement, (b, p) => new ValuePattern((TestBasicAutomationElement)b, p));
        }

        protected override IAutomationPattern<IVirtualizedItemPattern> InitializeVirtualizedItemPattern()
        {
            //#if NET35
            //            throw new NotSupportedByFrameworkException();
            //#else
            //            return new AutomationPattern<IVirtualizedItemPattern, UIA.VirtualizedItemPattern>(
            //                 VirtualizedItemPattern.Pattern, BasicAutomationElement, (b, p) => new VirtualizedItemPattern(b, p));
            //#endif
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IWindowPattern> InitializeWindowPattern()
        {
            //return new AutomationPattern<IWindowPattern, UIA.WindowPattern>(
            //    WindowPattern.Pattern, BasicAutomationElement, (b, p) => new WindowPattern(b, p));
            throw new NotSupportedByFrameworkException();
        }

        public override IAutomationPattern<T> GetCustomPattern<T, TNative>(PatternId pattern, Func<BasicAutomationElementBase, TNative, T> patternCreateFunc)
        {
            return new AutomationPattern<T, TNative>(pattern, BasicAutomationElement, patternCreateFunc);
        }
    }
}
