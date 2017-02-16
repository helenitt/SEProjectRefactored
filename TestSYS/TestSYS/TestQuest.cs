using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSYS
{
    class TestQuest
    {
        private int testId;
        private int questId;
        private int ansGiven;
        private int pointsAwarded;

        public TestQuest()
        {
            testId = 0;
            questId = 0;
            ansGiven = 0;
            pointsAwarded = 0;
        }

        public TestQuest(int tId, int qId, int ansGn, int pointsAwd)
        {
            testId = tId;
            questId = qId;
            ansGiven = ansGn;
            pointsAwarded = pointsAwd;
        }

        public int getTestId()
        {
            return testId;
        }

        public int getQuestId()
        {
            return questId;
        }

        public int getAnsGiven()
        {
            return ansGiven;
        }

        public int getPointsAwarded()
        {
            return pointsAwarded;
        }

        public void setTestId(int tId)
        {
            testId = tId;
        }

        public void setQuestId(int qId)
        {
            questId = qId;
        }

        public void setAnsGiven(int ansGn)
        {
            ansGiven = ansGn;
        }

        public void setPointsAwarded(int pointsAwd)
        {
            pointsAwarded = pointsAwd;
        }
    }
}
