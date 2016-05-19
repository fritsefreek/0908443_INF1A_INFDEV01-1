using System;

namespace INFDEV014 
{
	interface INumberVisitor {
		void onMyInt(MyInt x);
		void onMyFloat(MyFloat x);
	}
}