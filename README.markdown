__What is this?__

[GTFS](https://developers.google.com/transit/gtfs/reference) is a format for interchange of transportation information. But, due to the format's simple structure (CSV files), there is a is some data duplication.

This project is a simple processor that can take a GTFS zip and convert it into a compact sqlite3 database. This makes it a very good choice for mobile applications, where bandwidth matters.

Additionally, the nature of a sqlite3 database is much simpler to query against. Smaller chunks of data can be plucked from the tables and placed into memory (also constrained on mobile).

In Philadelphia, the bus and rail GTFS data is currently over 100MB uncompressed (15MB compressed). 

I'm not yet doing much clever with the packing of the data in the format, but experimentation has brought he filesize down to about 35MB uncompressed (~10MB compressed) -- most of those optimizations are not in master at this time.

__The code sucks__

Yep. I hacked it together and would like to improve it, but it's adequate for my needs. It's Open Source, feel free to write some tests or do some cleanup.

If you have a clever way to compact the DB further, I am also interested in hearing from you.

__Can it run on Mono?__

Yep, in fact, that's what I'm using to author the utility.