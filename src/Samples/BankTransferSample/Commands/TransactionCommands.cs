﻿using System;
using BankTransferSample.DomainEvents.Transaction;
using ENode.Commanding;

namespace BankTransferSample.Commands
{
    /// <summary>发起一笔转账交易
    /// </summary>
    [Serializable]
    public class StartTransaction : Command
    {
        public TransactionInfo TransactionInfo { get; private set; }

        public StartTransaction(TransactionInfo transactionInfo)
        {
            TransactionInfo = transactionInfo;
        }
    }
    /// <summary>确认预转出
    /// </summary>
    [Serializable]
    public class ConfirmDebitPreparation : Command
    {
        public Guid TransactionId { get; private set; }

        public ConfirmDebitPreparation(Guid transactionId)
        {
            TransactionId = transactionId;
        }
    }
    /// <summary>确认预转入
    /// </summary>
    [Serializable]
    public class ConfirmCreditPreparation : Command
    {
        public Guid TransactionId { get; private set; }

        public ConfirmCreditPreparation(Guid transactionId)
        {
            TransactionId = transactionId;
        }
    }
    /// <summary>确认转出
    /// </summary>
    [Serializable]
    public class ConfirmDebit : Command
    {
        public Guid TransactionId { get; private set; }

        public ConfirmDebit(Guid transactionId)
        {
            TransactionId = transactionId;
        }
    }
    /// <summary>确认转入
    /// </summary>
    [Serializable]
    public class ConfirmCredit : Command
    {
        public Guid TransactionId { get; private set; }

        public ConfirmCredit(Guid transactionId)
        {
            TransactionId = transactionId;
        }
    }
}
