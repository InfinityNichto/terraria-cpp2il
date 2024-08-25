using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004FC")]
	[global::System.Serializable]
	internal enum CorElementType : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001447")]
		End,
		[global::Cpp2ILInjected.Token(Token = "0x4001448")]
		Void,
		[global::Cpp2ILInjected.Token(Token = "0x4001449")]
		Boolean,
		[global::Cpp2ILInjected.Token(Token = "0x400144A")]
		Char,
		[global::Cpp2ILInjected.Token(Token = "0x400144B")]
		I1,
		[global::Cpp2ILInjected.Token(Token = "0x400144C")]
		U1,
		[global::Cpp2ILInjected.Token(Token = "0x400144D")]
		I2,
		[global::Cpp2ILInjected.Token(Token = "0x400144E")]
		U2,
		[global::Cpp2ILInjected.Token(Token = "0x400144F")]
		I4,
		[global::Cpp2ILInjected.Token(Token = "0x4001450")]
		U4,
		[global::Cpp2ILInjected.Token(Token = "0x4001451")]
		I8,
		[global::Cpp2ILInjected.Token(Token = "0x4001452")]
		U8,
		[global::Cpp2ILInjected.Token(Token = "0x4001453")]
		R4,
		[global::Cpp2ILInjected.Token(Token = "0x4001454")]
		R8,
		[global::Cpp2ILInjected.Token(Token = "0x4001455")]
		String,
		[global::Cpp2ILInjected.Token(Token = "0x4001456")]
		Ptr,
		[global::Cpp2ILInjected.Token(Token = "0x4001457")]
		ByRef,
		[global::Cpp2ILInjected.Token(Token = "0x4001458")]
		ValueType,
		[global::Cpp2ILInjected.Token(Token = "0x4001459")]
		Class,
		[global::Cpp2ILInjected.Token(Token = "0x400145A")]
		Var,
		[global::Cpp2ILInjected.Token(Token = "0x400145B")]
		Array,
		[global::Cpp2ILInjected.Token(Token = "0x400145C")]
		GenericInst,
		[global::Cpp2ILInjected.Token(Token = "0x400145D")]
		TypedByRef,
		[global::Cpp2ILInjected.Token(Token = "0x400145E")]
		I = 24,
		[global::Cpp2ILInjected.Token(Token = "0x400145F")]
		U,
		[global::Cpp2ILInjected.Token(Token = "0x4001460")]
		FnPtr = 27,
		[global::Cpp2ILInjected.Token(Token = "0x4001461")]
		Object,
		[global::Cpp2ILInjected.Token(Token = "0x4001462")]
		SzArray,
		[global::Cpp2ILInjected.Token(Token = "0x4001463")]
		MVar,
		[global::Cpp2ILInjected.Token(Token = "0x4001464")]
		CModReqd,
		[global::Cpp2ILInjected.Token(Token = "0x4001465")]
		CModOpt,
		[global::Cpp2ILInjected.Token(Token = "0x4001466")]
		Internal,
		[global::Cpp2ILInjected.Token(Token = "0x4001467")]
		Max,
		[global::Cpp2ILInjected.Token(Token = "0x4001468")]
		Modifier = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4001469")]
		Sentinel,
		[global::Cpp2ILInjected.Token(Token = "0x400146A")]
		Pinned = 69,
		[global::Cpp2ILInjected.Token(Token = "0x400146B")]
		ELEMENT_TYPE_END = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400146C")]
		ELEMENT_TYPE_VOID,
		[global::Cpp2ILInjected.Token(Token = "0x400146D")]
		ELEMENT_TYPE_BOOLEAN,
		[global::Cpp2ILInjected.Token(Token = "0x400146E")]
		ELEMENT_TYPE_CHAR,
		[global::Cpp2ILInjected.Token(Token = "0x400146F")]
		ELEMENT_TYPE_I1,
		[global::Cpp2ILInjected.Token(Token = "0x4001470")]
		ELEMENT_TYPE_U1,
		[global::Cpp2ILInjected.Token(Token = "0x4001471")]
		ELEMENT_TYPE_I2,
		[global::Cpp2ILInjected.Token(Token = "0x4001472")]
		ELEMENT_TYPE_U2,
		[global::Cpp2ILInjected.Token(Token = "0x4001473")]
		ELEMENT_TYPE_I4,
		[global::Cpp2ILInjected.Token(Token = "0x4001474")]
		ELEMENT_TYPE_U4,
		[global::Cpp2ILInjected.Token(Token = "0x4001475")]
		ELEMENT_TYPE_I8,
		[global::Cpp2ILInjected.Token(Token = "0x4001476")]
		ELEMENT_TYPE_U8,
		[global::Cpp2ILInjected.Token(Token = "0x4001477")]
		ELEMENT_TYPE_R4,
		[global::Cpp2ILInjected.Token(Token = "0x4001478")]
		ELEMENT_TYPE_R8,
		[global::Cpp2ILInjected.Token(Token = "0x4001479")]
		ELEMENT_TYPE_STRING,
		[global::Cpp2ILInjected.Token(Token = "0x400147A")]
		ELEMENT_TYPE_PTR,
		[global::Cpp2ILInjected.Token(Token = "0x400147B")]
		ELEMENT_TYPE_BYREF,
		[global::Cpp2ILInjected.Token(Token = "0x400147C")]
		ELEMENT_TYPE_VALUETYPE,
		[global::Cpp2ILInjected.Token(Token = "0x400147D")]
		ELEMENT_TYPE_CLASS,
		[global::Cpp2ILInjected.Token(Token = "0x400147E")]
		ELEMENT_TYPE_VAR,
		[global::Cpp2ILInjected.Token(Token = "0x400147F")]
		ELEMENT_TYPE_ARRAY,
		[global::Cpp2ILInjected.Token(Token = "0x4001480")]
		ELEMENT_TYPE_GENERICINST,
		[global::Cpp2ILInjected.Token(Token = "0x4001481")]
		ELEMENT_TYPE_TYPEDBYREF,
		[global::Cpp2ILInjected.Token(Token = "0x4001482")]
		ELEMENT_TYPE_I = 24,
		[global::Cpp2ILInjected.Token(Token = "0x4001483")]
		ELEMENT_TYPE_U,
		[global::Cpp2ILInjected.Token(Token = "0x4001484")]
		ELEMENT_TYPE_FNPTR = 27,
		[global::Cpp2ILInjected.Token(Token = "0x4001485")]
		ELEMENT_TYPE_OBJECT,
		[global::Cpp2ILInjected.Token(Token = "0x4001486")]
		ELEMENT_TYPE_SZARRAY,
		[global::Cpp2ILInjected.Token(Token = "0x4001487")]
		ELEMENT_TYPE_MVAR,
		[global::Cpp2ILInjected.Token(Token = "0x4001488")]
		ELEMENT_TYPE_CMOD_REQD,
		[global::Cpp2ILInjected.Token(Token = "0x4001489")]
		ELEMENT_TYPE_CMOD_OPT,
		[global::Cpp2ILInjected.Token(Token = "0x400148A")]
		ELEMENT_TYPE_INTERNAL,
		[global::Cpp2ILInjected.Token(Token = "0x400148B")]
		ELEMENT_TYPE_MAX,
		[global::Cpp2ILInjected.Token(Token = "0x400148C")]
		ELEMENT_TYPE_MODIFIER = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400148D")]
		ELEMENT_TYPE_SENTINEL,
		[global::Cpp2ILInjected.Token(Token = "0x400148E")]
		ELEMENT_TYPE_PINNED = 69
	}
}
