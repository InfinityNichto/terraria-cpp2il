using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000296")]
public static class MessageBox
{
	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public static bool IsVisible
	{
		[Cpp2IlInjected.Token(Token = "0x60014BE")]
		[Cpp2IlInjected.Address(RVA = "0x1577A60", Offset = "0x1577A60", VA = "0x1577A60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60014BF")]
		[Cpp2IlInjected.Address(RVA = "0x1577AB8", Offset = "0x1577AB8", VA = "0x1577AB8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60014C0")]
	[Cpp2IlInjected.Address(RVA = "0x1577B14", Offset = "0x1577B14", VA = "0x1577B14")]
	[Cpp2IlInjected.Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x38E528", Offset = "0x38E528")]
	public static Task<int?> Show(string title, string description, IEnumerable<string> buttons)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60014C1")]
	[Cpp2IlInjected.Address(RVA = "0x1577C40", Offset = "0x1577C40", VA = "0x1577C40")]
	public static void Cancel(int? result)
	{
	}
}
