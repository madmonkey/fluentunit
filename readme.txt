This was derived from a number of relevant posts and samples. I found this particular 
combination of techniques to particularly useful for my needs. Feel free to fork/modify
for your particular situation. 

You want to implement session-per-request, which can be done a number of
ways.

On application startup:

   1. Configure NHibernate following the FNH docs. This takes care of all
   the mapping magic. The fluent syntax ends by building a session factory.
   2. Hold on to the session factory for as long as your application is
   alive. It is your one and only session factory. This can be as simple as a
   static field in the global.asax, though I prefer to put it in my IoC
   container.

On request start:

   1. Using the session factory, open a session. This is cheap. It doesn't
   open a database connection. Don't worry about opening a session when it's
   not used.
   2. Make the session available for the lifetime of the request. You have
   two good options:
      1. Put it in your IoC container
      2. Use NHibernate contextual sessions, so you would call
      sessionFactory.GetCurrentSession() to find the session for this request.
      http://nhforge.org/doc/nh/en/index.html#architecture-current-session

On request end:

   1. Close or Dispose the session. 