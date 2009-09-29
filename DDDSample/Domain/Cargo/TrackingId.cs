﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDSample.Domain.Cargo
{
   /// <summary>
   /// Uniquely identifies a particular cargo. Automatically generated by the application.
   /// </summary>
   public sealed class TrackingId : ValueObject
   {
      private readonly string _idString;

      /// <summary>
      /// Creates new <see cref="TrackingId"/> instacnce.
      /// </summary>
      /// <param name="idString">String representation of this new tracking id.</param>
      public TrackingId(string idString)
      {
         _idString = idString;
      }

      /// <summary>
      /// Returns string representation of this tracking id.
      /// </summary>
      public string IdString
      {
         get { return _idString; }
      }

      public override bool Equals(object obj)
      {
         TrackingId other = obj as TrackingId;
         return other != null && _idString.Equals(other._idString);
      }

      public override int GetHashCode()
      {
         return _idString.GetHashCode();
      }

      public static bool operator == (TrackingId left, TrackingId right)
      {
         return EqualOperator(left, right);
      }

      public static bool operator !=(TrackingId left, TrackingId right)
      {
         return NotEqualOperator(left, right);
      }
   }
}