using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace NaughtyAttributes
{
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public interface IDropdownList : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
	}
}
