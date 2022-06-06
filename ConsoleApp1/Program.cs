// See https://aka.ms/new-console-template for more information


IDataService<User> userService = new GenericDataService<User>(new TraderDbContextFactory());
