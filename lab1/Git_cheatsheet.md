# **Git Cheatsheet**

A cheatsheet for common Git commands.

## **Table of Contents**

- **Setup and Configuration**
- **Basic Commands**
- **Branching and Merging**
- **Staging and Committing**
- **Remote Repositories**
- **Viewing History and Diffs**
- **Advanced Git Commands**

## **Setup and Configuration**

- **Set your name**:  
  `git config --global user.name "Your Name"`

- **Set your email**:  
  `git config --global user.email "your.email@example.com"`

- **Check config**:  
  `git config --list`

- **Set default editor (e.g., Vim)**:  
  `git config --global core.editor "vim"`

- **Unset a configuration**:  
  `git config --global --unset user.name`

## **Basic Commands**

- **Initialize a new repository**:  
  `git init`

- **Clone a repository**:  
  `git clone <url>`

- **Check status**:  
  `git status`

- **View changes**:  
  `git diff`

- **View detailed file status**:  
  `git status -v`

## **Branching and Merging**

- **List branches**:  
  `git branch`

- **Create a new branch**:  
  `git branch <branch-name>`

- **Switch to a branch**:  
  `git checkout <branch-name>`

- **Create and switch to a new branch**:  
  `git checkout -b <branch-name>`

- **Merge a branch**:  
  `git merge <branch-name>`

- **Delete a branch**:  
  `git branch -d <branch-name>`

- **Force delete a branch (use with caution)**:  
  `git branch -D <branch-name>`

- **List all branches (including remote)**:  
  `git branch -a`

- **Rename current branch**:  
  `git branch -m <new-name>`

## **Staging and Committing**

- **Stage files**:  
  `git add <file>` or `git add .` (stages all changes)

- **Commit changes**:  
  `git commit -m "Your commit message"`

- **Commit changes with a specific editor**:  
  `git commit`

- **Commit all changes and skip the editor**:  
  `git commit -am "Your commit message"`

- **View commit history**:  
  `git log`

- **View commit history in one line**:  
  `git log --oneline`

- **View a specific file's commit history**:  
  `git log <file>`

- **Show commit differences**:  
  `git diff <commit1> <commit2>`

## **Remote Repositories**

- **Add a remote**:  
  `git remote add origin <url>`

- **Push to remote**:  
  `git push origin <branch-name>`

- **Pull from remote**:  
  `git pull origin <branch-name>`

- **Fetch without merging**:  
  `git fetch origin`

- **List remotes**:  
  `git remote -v`

- **Remove a remote**:  
  `git remote remove <remote-name>`

- **Push a new tag to remote**:  
  `git push origin <tag-name>`

- **Push all branches**:  
  `git push --all origin`

- **Push a specific tag**:  
  `git push origin <tag-name>`

## **Viewing History and Diffs**

- **View changes in a file**:  
  `git diff <file>`

- **View who changed what**:  
  `git blame <file>`

- **View a file's history**:  
  `git log <file>`

- **Show the changes in a specific commit**:  
  `git show <commit-hash>`

- **Compare changes between branches**:  
  `git diff <branch1> <branch2>`

- **View commit history with diff**:  
  `git log -p`

- **Show a commit with a summary**:  
  `git show --stat <commit-hash>`

## **Advanced Git Commands**

- **Stash changes**: Temporarily saves uncommitted changes to apply later.  
  `git stash`  
  Save changes temporarily to apply later.

- **Apply stashed changes**: Reapplies changes from the stash to the working directory.  
  `git stash apply`

- **List stashes**: Displays a list of all stashed changes.  
  `git stash list`

- **Drop a specific stash**: Removes a specific stash from the stash list.  
  `git stash drop <stash@{0}>`

- **Delete all stashes**: Clears all stashed changes.  
  `git stash clear`

- **Revert a commit**: Creates a new commit that undoes a previous commit.  
  `git revert <commit-hash>`

- **Reset to a previous commit (soft, mixed, or hard)**:  
  Resets the repository to a specific commit, with different options for keeping or discarding changes.
  - Soft (keeps changes in staging):  
    `git reset --soft <commit-hash>`
  
  - Mixed (keeps changes, but unstages them):  
    `git reset --mixed <commit-hash>`
  
  - Hard (discards changes):  
    `git reset --hard <commit-hash>`

- **Show diff of changes between working directory and staging**: Displays differences between unstaged and staged changes.  
  `git diff`

- **Undo last commit but keep changes**: Undoes the last commit but keeps the changes in the working directory.  
  `git reset --soft HEAD~1`

- **Show current branch**: Displays the name of the current branch.  
  `git branch --show-current`

- **Create a new tag**: Adds a new tag to the current commit.  
  `git tag <tag-name>`

- **List all tags**: Displays a list of all tags in the repository.  
  `git tag`

- **Delete a local tag**: Deletes a specific local tag.  
  `git tag -d <tag-name>`

- **Delete a remote tag**: Removes a tag from the remote repository.  
  `git push --delete origin <tag-name>`

- **Rebase a branch**: Reapplies commits from the current branch onto another branch.  
  `git rebase <branch-name>`

- **Squash commits**: Combines multiple commits into one.  
  `git rebase -i <commit-hash>`

- **Show the diff of staged changes**: Displays differences between the staged changes and the previous commit.  
  `git diff --staged`
