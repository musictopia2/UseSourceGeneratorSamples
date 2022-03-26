namespace FirstSimpleMappingSample;
internal class CustomContext : MappingCloningContext
{
    protected override void Configure(ICustomConfig config)
    {
        config.Make<ClassA>(x => x.MapTo<ClassB>(y =>
        {

        }))
            .Make<ClassC>(x => x.MapTo<ClassD>(y =>
            {

            }));
        //you can chain them because its the fluent design.
    }
}