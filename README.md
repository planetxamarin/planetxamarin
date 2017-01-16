# Welcome [![Build status](https://ci.appveyor.com/api/projects/status/xtmmldw1i60q2yv5?svg=true)](https://ci.appveyor.com/project/ghuntley/planetxamarin)

Hi! Welcome to Readify!

We're serious about demonstrating trust in our people and giving them both opportunities to grow and platforms to showcase their work. This is both of those.

# What is The Firehose?

The Firehose is our blog aggregation platform. If you're a Readifarian, you belong here. You're welcome to add your blog and have it aggregated as part of our feed.

# Do I have to join it?

Absolutely not.

It's completely, entirely and utterly optional. It's a way to get your voice heard by a larger audience (at least, that's what we're hoping to make it) but you're by no means obliged to add your blog(s) to be aggregated.

# We trust you

So please don't abuse that.

We're giving you this opportunity to speak in our name. It's not legally binding and we have all the right disclaimers in place, but nonetheless, we're trusting you to not be a twit, get yourself into trouble or bring our (your) name into disrepute.

# Do I still own my content?

Absolutely. We have no designs on your IP beyond what's written into your employment contract. What you blog, tweet, Facebook, Instagram etc. is yours alone.

We'll promote your stuff for you inasmuch as we provide a platform. That's it :)

# Getting started

## How do I get my blog aggregated?

Clone the Firehose repository on GitHub and add a class that looks something like this in the Authors namespace:  

    namespace Firehose.Web.Authors
    {
        public class AndrewHarcourt : IAmAReadifarian
        {
            // TODO: Fill in all your details
        }
    }

Commit and push your changes.

Make sure that your RSS generator is setting an author tag for each post so that your name still appears correctly
once it's aggregated!

## What if I want to only syndicate some of my posts?

    namespace Firehose.Web.Authors
    {
        public class AndrewHarcourt : IAmAReadifarian, IFilterMyBlogPosts
        {
            // TODO: Fill in all your details
            // TODO implement the Filter method any way you like :)
        }
    }

# Don't I have to ask someone before I do this?

Nope. You've been asked because you're a Readifarian. We trust you. **You belong here.**
