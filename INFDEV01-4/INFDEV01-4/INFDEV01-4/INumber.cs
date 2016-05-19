using System;

namespace INFDEV014
{
	interface INumber
	{
		void visit(INumberVisitor x);
	}
}