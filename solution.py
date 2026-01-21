class Solution:
    def sortPeople(self, names, heights):
        d = {}
        for i in range(len(heights)): d[heights[i]] = names[i]

        ret = []
        for x in sorted(d, reverse = True): ret.append(d[x])

        return ret
