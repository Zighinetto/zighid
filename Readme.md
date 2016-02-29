#Zighinetto ID provider

A simple OpenID provider for the ultimate *nerd*

##What does it do

Provides OpenID authentication on own vanity domain name (e.g. https://mynickname.nerd) with username/password authentication and optional two-factor authentication.

It is just a .NET clone of [phpMyId](https://github.com/sole/phpMyID) that adds stronger verification. Still no database needed.

##Why?

 - Because author doesn't want his identity to rely on Google or, worse, Facebook
 - Because author likes to use the vanity domain name https://www.zighinetto.org
 - Because phpMyId does not support two-factor authentication
 - Because author :cupid: ASP.NET
 - Because author is affected by the [Not Invented Here Syndrome](https://en.wikipedia.org/wiki/Not_invented_here)
 - Maybe because author has lots of spare time? No :sad:

Really, since phpMyId provides only password authentication, I have two options: one is to use a strong password that can be only copied&pasted from KeePass 
(or written to a [post it](http://thedailywtf.com/articles/Security-by-PostIt) on the screen) I chose to write my own provider. The point is that the *password*
could still be a weaker password but must be backed by a stronger security element such as Authenticator app for smartphone, based on [RFC 4226](https://tools.ietf.org/html/rfc4226)
(this may change though I have no reason to, at the moment)

##Kudos
The design is not mine. I just grabbed a [free template](http://startbootstrap.com/template-overviews/stylish-portfolio/) from Bootstrap, for which all the credit goes to the author.
If you ever wanted to fork this project you could change the entire template in the master page. Feel free to make a clone.

##Future

At the moment, a decent and working **implementation** is *future*. However, I'd also like to implement a very simple captcha block in case of multiple login attempts. And again, all
the project requires no database to run. Why the hell implement an entire database for just one user? Yes, this application is supposed to serve **a single identity**.

But in the future that may change...