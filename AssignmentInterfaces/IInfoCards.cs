using System.Collections.Generic;

public interface IInfoCards : IList<IInfoCard>
{
    bool Load(string fileName, GetFactory getFactory);
    void Save(string fileName);
}
