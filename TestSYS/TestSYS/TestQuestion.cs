using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSYS
{
    class TestQuestion
    {
        private int testId;
        private int questId;
        private int ansGiven;

        public TestQuestion()
        {
            testId = 0;
            questId = 0;
            ansGiven = 0;
        }

        public TestQuestion(int tId, int qId, int ansGiven)
        {
            testId = tId;
            questId = qId;
            this.ansGiven = ansGiven;
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

        public void setTestId(int tId)
        {
            testId = tId;
        }
        public void setQuestId(int qId)
        {
            questId = qId;
        }
        public void setAnsGiven(int aGiven)
        {
            ansGiven = aGiven;
        }
    }
}
