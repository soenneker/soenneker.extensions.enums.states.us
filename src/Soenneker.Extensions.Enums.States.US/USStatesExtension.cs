using Soenneker.Enums.States.US;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Enums.States.US;

/// <summary>
/// A collection of helpful US State enum extension methods
/// </summary>
public static class USStatesExtension
{
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToFullName(this USState? state)
    {
        if (state is null)
            return string.Empty;

        return state.Value switch
        {
            USState.ALValue => "Alabama",
            USState.AKValue => "Alaska",
            USState.AZValue => "Arizona",
            USState.ARValue => "Arkansas",
            USState.CAValue => "California",
            USState.COValue => "Colorado",
            USState.CTValue => "Connecticut",
            USState.DEValue => "Delaware",
            USState.FLValue => "Florida",
            USState.GAValue => "Georgia",
            USState.HIValue => "Hawaii",
            USState.IDValue => "Idaho",
            USState.ILValue => "Illinois",
            USState.INValue => "Indiana",
            USState.IAValue => "Iowa",
            USState.KSValue => "Kansas",
            USState.KYValue => "Kentucky",
            USState.LAValue => "Louisiana",
            USState.MEValue => "Maine",
            USState.MDValue => "Maryland",
            USState.MAValue => "Massachusetts",
            USState.MIValue => "Michigan",
            USState.MNValue => "Minnesota",
            USState.MSValue => "Mississippi",
            USState.MOValue => "Missouri",
            USState.MTValue => "Montana",
            USState.NEValue => "Nebraska",
            USState.NVValue => "Nevada",
            USState.NHValue => "New Hampshire",
            USState.NJValue => "New Jersey",
            USState.NMValue => "New Mexico",
            USState.NYValue => "New York",
            USState.NCValue => "North Carolina",
            USState.NDValue => "North Dakota",
            USState.OHValue => "Ohio",
            USState.OKValue => "Oklahoma",
            USState.ORValue => "Oregon",
            USState.PAValue => "Pennsylvania",
            USState.RIValue => "Rhode Island",
            USState.SCValue => "South Carolina",
            USState.SDValue => "South Dakota",
            USState.TNValue => "Tennessee",
            USState.TXValue => "Texas",
            USState.UTValue => "Utah",
            USState.VTValue => "Vermont",
            USState.VAValue => "Virginia",
            USState.WAValue => "Washington",
            USState.WVValue => "West Virginia",
            USState.WIValue => "Wisconsin",
            USState.WYValue => "Wyoming",
            _ => state.Value
        };
    }
}