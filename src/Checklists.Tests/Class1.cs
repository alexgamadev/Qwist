using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checklists.Tests;
public class Class1
{
    [Fact]
    public void InitialTest_InputIsTrue_ReturnTrue()
    {
        // Arrange
        bool boolean = true;
        // Act
        // Assert
        Assert.True(boolean);
    }
}
