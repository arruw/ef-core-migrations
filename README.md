# Example 1
https://channel9.msdn.com/blogs/ef/migrations-team-environments

User 1:
1. Add new property Blog.Rating
2. Add migration
3. Update database
4. Commit changes and push to remote

User 2:
5. Add new property Blog.Readers
6. Add migration
7. Update database
8. Commit changes and try to push
9. Pull changes from remote
10. Keep local snapshot file
11. Resolve other merge conflicts
12. Add merge migration (empty migration)
13. Update database
14. Commit merge and push to remote