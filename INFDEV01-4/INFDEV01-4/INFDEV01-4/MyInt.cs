using System;

namespace INFDEV014
{
	class MyInt: INumber
	{
		public void visit(INumberVisitor INumberVisitor)
		{
			INumberVisitor.onMyInt(this);
		}
	}
}