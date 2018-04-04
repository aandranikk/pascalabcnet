using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PascalABCCompiler.SyntaxTree;

namespace SyntaxVisitors.SugarVisitors
{
    public class RegexDesugarVisitor : BaseChangeVisitor
    {
        public static RegexDesugarVisitor New
        {
            get { return new RegexDesugarVisitor(); }
        }

        public override void visit(regex rx)
        {
            var el = new expression_list(
                new string_const(rx.Value, rx.source_context), rx.source_context);
            var ne = new new_expr("System.Text.RegularExpressions.Regex", el);

            ReplaceUsingParent(rx, ne);

            visit(ne);
        }

        /*public override void visit(program_module pm)
        {
            var il = new ident_list();
            il.Add(new ident("System")).Add("Text").Add("RegularExpressions");
            if (pm.used_units == null)
                pm.used_units = new uses_list();
            pm.used_units.units.Add(new unit_or_namespace(il));
        }*/
    }
}
