using System;
using System.Reflection;

namespace AutoMapper
{
    using Configuration.Conventions;

    public interface ISourceToDestinationNameMapper
    {
        MemberInfo GetMatchingMemberInfo(IGetTypeInfoMembers getTypeInfoMembers, TypeDetails typeInfo, Type destType, Type destMemberType, string nameToSearch);
    }
}