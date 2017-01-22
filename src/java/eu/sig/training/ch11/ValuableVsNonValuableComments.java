  // This unit suggest labels for autocompletion
  public AutoCompletionCandidates doAutoCompleteLabels(@QueryParameter String value) {
        AutoCompletionCandidates result = new AutoCompletionCandidates();
        // show all suggestions for short strings
        if (query.length() < 2) {
            result.add(getProjectLabelsAsArray(job));
        } else {
            for (String branch : getProjectLabelsAsArray(job)) {
                if (branch.toLowerCase().contains(query.toLowerCase())) {
                    result.add(branch);
                }
            }
        }
        return result;
}
