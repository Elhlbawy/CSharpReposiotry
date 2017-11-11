using System;
using System.Collections.Generic;
using System.Text;

namespace ChSharpCon
{
    class ValueDataType
    {
        /* The value types consist of two main categories:
           -- Structs
           -- Enumerations
           && Structs fall into these categories:
           1- Numeric types
           2- Integral types
           3- Floating-point types
           4- decimal
           5- bool
           6- User defined structs.

        Variables that are based on value types directly contain values. 
        Assigning one value type variable to another copies the contained value.
        This differs from the assignment of reference type variables, 
        which copies a reference to the object but not the object itself. 
         All value types are derived implicitly from the System.ValueType.

    ** Unlike with reference types, you cannot derive a new type from a value type.
    However, like reference types, structs can implement interfaces.
    -- Unlike reference types, a value type cannot contain the null value. 
    int i = null; Not Allowed
    However, the nullable types feature does allow for value types to be assigned to null.
    int? i = null; Allowed
    ** Each value type has an implicit default constructor that initializes 
    the default value of that type. 
   
    */

        // Value Types 
        // 1- bool for Boolean Values

        public void boolMethodType()
        {
            bool b = true;

            // print the value b 
            Console.WriteLine(b);

        }

    }
}
