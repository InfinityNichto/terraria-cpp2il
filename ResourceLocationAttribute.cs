using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "AttributeUsageAttribute", RVA = "0x384A90", Offset = "0x384A90")]
public class ResourceLocationAttribute : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string Location;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xF998EC", Offset = "0xF998EC", VA = "0xF998EC")]
	public ResourceLocationAttribute(string location)
	{
	}
}
