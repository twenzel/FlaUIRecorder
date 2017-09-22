using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.Identifiers;

namespace FlaUIRecorder.Tests.Common
{
    public class TestPatternLibrary : IPatternLibrary
    {
        public PatternId AnnotationPattern => throw new NotImplementedException();

        public PatternId DockPattern => throw new NotImplementedException();

        public PatternId DragPattern => throw new NotImplementedException();

        public PatternId DropTargetPattern => throw new NotImplementedException();

        public PatternId ExpandCollapsePattern => throw new NotImplementedException();

        public PatternId GridItemPattern => throw new NotImplementedException();

        public PatternId GridPattern => throw new NotImplementedException();

        public PatternId InvokePattern => throw new NotImplementedException();

        public PatternId ItemContainerPattern => throw new NotImplementedException();

        public PatternId LegacyIAccessiblePattern => throw new NotImplementedException();

        public PatternId MultipleViewPattern => throw new NotImplementedException();

        public PatternId ObjectModelPattern => throw new NotImplementedException();

        public PatternId RangeValuePattern => throw new NotImplementedException();

        public PatternId ScrollItemPattern => throw new NotImplementedException();

        public PatternId ScrollPattern => throw new NotImplementedException();

        public PatternId SelectionItemPattern => throw new NotImplementedException();

        public PatternId SelectionPattern => throw new NotImplementedException();

        public PatternId SpreadsheetItemPattern => throw new NotImplementedException();

        public PatternId SpreadsheetPattern => throw new NotImplementedException();

        public PatternId StylesPattern => throw new NotImplementedException();

        public PatternId SynchronizedInputPattern => throw new NotImplementedException();

        public PatternId TableItemPattern => throw new NotImplementedException();

        public PatternId TablePattern => throw new NotImplementedException();

        public PatternId TextChildPattern => throw new NotImplementedException();

        public PatternId TextEditPattern => throw new NotImplementedException();

        public PatternId Text2Pattern => throw new NotImplementedException();

        public PatternId TextPattern => Patterns.TextPattern.Pattern;

        public PatternId TogglePattern => throw new NotImplementedException();

        public PatternId Transform2Pattern => throw new NotImplementedException();

        public PatternId TransformPattern => throw new NotImplementedException();

        public PatternId ValuePattern => Patterns.ValuePattern.Pattern;

        public PatternId VirtualizedItemPattern => throw new NotImplementedException();

        public PatternId WindowPattern => throw new NotImplementedException();

        public PatternId[] AllForCurrentFramework => new PatternId[]
        {
            //this.DockPattern,
            //this.ExpandCollapsePattern,
            //this.GridItemPattern,
            //this.GridPattern,
            //this.InvokePattern,
            //this.ItemContainerPattern,
            //this.MultipleViewPattern,
            //this.RangeValuePattern,            
            //this.SelectionItemPattern,
            //this.SelectionPattern,
            //this.SynchronizedInputPattern,
            //this.TableItemPattern,
            //this.TablePattern,
            this.TextPattern,
            //this.TogglePattern,
            //this.TransformPattern,
            this.ValuePattern 
            //this.WindowPattern
    };
    }
}
