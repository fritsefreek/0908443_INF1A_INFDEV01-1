using System;

namespace INFDEV014
{
	public class MyFloat : INumber
	{
		public void visit(INumberVisitor INumberVisitor)
		{
			INumberVisitor.onMyFloat(this);
		}
	}
}