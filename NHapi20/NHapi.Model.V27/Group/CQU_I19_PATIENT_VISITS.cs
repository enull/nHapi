using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V27.Segment;
using NHapi.Model.V27.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V27.Group
{
///<summary>
///Represents the CQU_I19_PATIENT_VISITS Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PV1 (Patient Visit) </li>
///<li>1: PV2 (Patient Visit - Additional Information) optional </li>
///</ol>
///</summary>
[Serializable]
public class CQU_I19_PATIENT_VISITS : AbstractGroup {

	///<summary> 
	/// Creates a new CQU_I19_PATIENT_VISITS Group.
	///</summary>
	public CQU_I19_PATIENT_VISITS(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PV1), true, false);
	      this.add(typeof(PV2), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CQU_I19_PATIENT_VISITS - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PV1 (Patient Visit) - creates it if necessary
	///</summary>
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.GetStructure("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PV2 (Patient Visit - Additional Information) - creates it if necessary
	///</summary>
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.GetStructure("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
