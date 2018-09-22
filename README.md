# Example 1
https://channel9.msdn.com/blogs/ef/migrations-team-environments

**User 1:**
1. Add new property Blog.Rating
2. Add migration
3. Update database
4. Commit changes and push to remote

**User 2:**
1. Add new property Blog.Readers
2. Add migration
3. Update database
4. Commit changes and try to push
5. Pull changes from remote
6. Keep local snapshot file
7. Resolve other merge conflicts
8. Add merge migration
9. Clean Up and Down migration methods (empty migration)
10. Update database
11. Commit merge and push to remote
