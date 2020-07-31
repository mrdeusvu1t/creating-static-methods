namespace CreatingMethods
{
    public static class MethodsWithRefParameters
    {
        public static bool ReturnParameterValueAndSetParameterToDefaultValue(ref bool boolValue)
        {
            bool value = boolValue;
            boolValue = default(bool);
            return value;
        }

        // TODO #17. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue" that gets "charValue" parameter ("char" type) with ref keyword. The method should return value of "charValue" parameter and set the "charValue" parameter to default value (use "default" operator).

        // TODO #18. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue" that gets "floatValue" parameter ("float" type) with ref keyword. The method should return value of "floatValue" parameter and set the "floatValue" parameter to default value (use "default" operator).

        // TODO #19. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue" that gets "intValue" parameter ("int" type) with ref keyword. The method should return value of "intValue" parameter and set the "intValue" parameter to default value (use "default" operator).

        // TODO #20. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue" that gets "longValue" parameter ("long" type) with ref keyword. The method should return value of "longValue" parameter and set the "longValue" parameter to default value (use "default" operator).
    }
}
