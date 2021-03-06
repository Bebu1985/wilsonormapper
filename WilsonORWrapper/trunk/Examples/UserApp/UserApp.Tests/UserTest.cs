//------------------------------------------------------------------------------
// <autogenerated>
//		This code was generated by a CodeSmith Template.
//
//		This template is the begining of the test cases for the business objects.
//      This is not a complete set of tests. Please add more tests.
// </autogenerated>
//------------------------------------------------------------------------------

using System.Collections.ObjectModel;
using NUnit.Framework;
using Wilson.ORMapper;
using UserApp.Entities;
using UserApp.Services;

namespace UserApp.Tests
{
	/// <summary>
	/// This class is a test case for User and UserService.
	/// </summary>
	[TestFixture()]		
	public class UserTest
	{
		public UserTest()
		{
		}
		
		[Test()]
		public void UserCreate()
		{		
			User instance1 = new User();
			Assert.IsNotNull(instance1, "UserTest.UserNew: Unable to create instance using new()");
			User instance2 = UserService.Create();
			Assert.IsNotNull(instance2, "UserTest.UserCreate: Unable to create instance");
		}

		[Test()]
		public void UserRetrieve()
		{
			User instance = UserService.RetrieveFirst("");
			Assert.IsNotNull(instance, "User.RetrieveFirst: null retrieved (are you missing test data?)");
			
			// TODO: Retrieve by Key, using the PKs of instance, 
			// then compare that they are equal 
			// To do this we need a GetIdentity() field on the EntityBase that returns an IIdentity
			//Assert.AreEqual(key, instance.KeyName);
		}
		
		
		[Test()]
		public void UserSave()
		{		
			User instance = new User();
			Assert.IsNotNull(instance, "UserTest.UserNew: Unable to create instance using new()");
			
			//TODO Set values
			
			//instance.Save();
		}
		
		[Test()]
		public void UserRetrieveAll()
		{
			Collection<User> list = UserService.Retrieve();
			Assert.IsNotNull(list, "UserTest.RetrieveAll: null retrieved (are you missing test data?)"); 
			Assert.IsTrue(list.Count > 0, "UserTest.RetrieveAll(): no rows retrieved (are you missing test data?)");
		}

		[Test()]
		public void UserRetrievePage()
		{
			int pageSize = 10;
			int pageIndex = 1;
			int pageCount;
			
			Collection<User> list = UserService.RetrievePage(pageSize, pageIndex, out pageCount);
			Assert.IsNotNull(list, "UserTest.RetrieveAll: null retrieved (are you missing test data?)");
			Assert.IsTrue(list.Count > 0, "UserTest.RetrieveAll(): no rows retrieved (are you missing test data?)");
		}

	}
}

