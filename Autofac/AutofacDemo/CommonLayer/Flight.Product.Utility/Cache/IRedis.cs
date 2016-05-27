﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flight.Product.Utility
{
    public interface IRedis
    {
        IDisposable AcquireLock(string key);
        IDisposable AcquireLock(string key, TimeSpan timeOut);
        bool Add<T>(string key, T value);
        bool Add<T>(string key, T value, DateTime expiresAt);
        bool Add<T>(string key, T value, TimeSpan expiresIn);
        void AddItemToList(string listId, string value);
        void AddItemToSet(string setId, string item);
        bool AddItemToSortedSet(string setId, string value);
        bool AddItemToSortedSet(string setId, string value, double score);
        bool AddItemToSortedSet(string setId, string value, long score);
        void AddRangeToList(string listId, List<string> values);
        void AddRangeToSet(string setId, List<string> items);
        bool AddRangeToSortedSet(string setId, List<string> values, double score);
        bool AddRangeToSortedSet(string setId, List<string> values, long score);
        long AppendToValue(string key, string value);
        string BlockingDequeueItemFromList(string listId, TimeSpan? timeOut);
        string BlockingPopAndPushItemBetweenLists(string fromListId, string toListId, TimeSpan? timeOut);
        string BlockingPopItemFromList(string listId, TimeSpan? timeOut);
        string BlockingRemoveStartFromList(string listId, TimeSpan? timeOut);
        void ChangeDb(long db);
        bool ContainsKey(string key);
        long Decrement(string key, uint amount);
        long DecrementValue(string key);
        long DecrementValueBy(string key, int count);
        void Delete<T>(T entity);
        void DeleteAll<T>();
        void DeleteById<T>(object id);
        void DeleteByIds<T>(ICollection ids);
        string DequeueItemFromList(string listId);
        void EnqueueItemOnList(string listId, string value);
        long ExecLuaAsInt(string body, params string[] args);
        long ExecLuaAsInt(string luaBody, string[] keys, string[] args);
        List<string> ExecLuaAsList(string body, params string[] args);
        List<string> ExecLuaAsList(string luaBody, string[] keys, string[] args);
        string ExecLuaAsString(string body, params string[] args);
        string ExecLuaAsString(string sha1, string[] keys, string[] args);
        long ExecLuaShaAsInt(string sha1, params string[] args);
        long ExecLuaShaAsInt(string sha1, string[] keys, string[] args);
        List<string> ExecLuaShaAsList(string sha1, params string[] args);
        List<string> ExecLuaShaAsList(string sha1, string[] keys, string[] args);
        string ExecLuaShaAsString(string sha1, params string[] args);
        string ExecLuaShaAsString(string sha1, string[] keys, string[] args);
        bool ExpireEntryAt(string key, DateTime expireAt);
        bool ExpireEntryIn(string key, TimeSpan expireIn);
        T Get<T>(string key);
        IList<T> GetAll<T>();
        IDictionary<string, T> GetAll<T>(IEnumerable<string> keys);
        Dictionary<string, string> GetAllEntriesFromHash(string hashId);
        List<string> GetAllItemsFromList(string listId);
        HashSet<string> GetAllItemsFromSet(string setId);
        List<string> GetAllItemsFromSortedSet(string setId);
        List<string> GetAllItemsFromSortedSetDesc(string setId);
        List<string> GetAllKeys();
        IDictionary<string, double> GetAllWithScoresFromSortedSet(string setId);
        string GetAndSetEntry(string key, string value);
        T GetById<T>(object id);
        IList<T> GetByIds<T>(ICollection ids);
        List<Dictionary<string, string>> GetClientList();
        string GetConfig(string configItem);
        HashSet<string> GetDifferencesFromSet(string fromSetId, params string[] withSetIds);
        T GetFromHash<T>(object id);
        long GetHashCount(string hashId);
        List<string> GetHashKeys(string hashId);
        List<string> GetHashValues(string hashId);
        HashSet<string> GetIntersectFromSets(params string[] setIds);
        string GetItemFromList(string listId, int listIndex);
        long GetItemIndexInSortedSet(string setId, string value);
        long GetItemIndexInSortedSetDesc(string setId, string value);
        double GetItemScoreInSortedSet(string setId, string value);
        long GetListCount(string listId);
        string GetRandomItemFromSet(string setId);
        string GetRandomKey();
        List<string> GetRangeFromList(string listId, int startingFrom, int endingAt);
        List<string> GetRangeFromSortedList(string listId, int startingFrom, int endingAt);
        List<string> GetRangeFromSortedSet(string setId, int fromRank, int toRank);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, double fromScore, double toScore);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, long fromScore, long toScore);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, double fromScore, double toScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, long fromScore, long toScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, double fromScore, double toScore);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, long fromScore, long toScore);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, double fromScore, double toScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, long fromScore, long toScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
        List<string> GetRangeFromSortedSetDesc(string setId, int fromRank, int toRank);
        IDictionary<string, double> GetRangeWithScoresFromSortedSet(string setId, int fromRank, int toRank);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, double fromScore, double toScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, long fromScore, long toScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, double fromScore, double toScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, long fromScore, long toScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, double fromScore, double toScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, long fromScore, long toScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, double fromScore, double toScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, long fromScore, long toScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
        IDictionary<string, double> GetRangeWithScoresFromSortedSetDesc(string setId, int fromRank, int toRank);
        long GetSetCount(string setId);
        List<string> GetSortedEntryValues(string setId, int startingFrom, int endingAt);
        long GetSortedSetCount(string setId);
        long GetSortedSetCount(string setId, double fromScore, double toScore);
        long GetSortedSetCount(string setId, long fromScore, long toScore);
        long GetSortedSetCount(string setId, string fromStringScore, string toStringScore);
        TimeSpan GetTimeToLive(string key);
        string GetTypeIdsSetKey<T>();
        string GetTypeIdsSetKey(Type type);
        string GetTypeSequenceKey<T>();
        HashSet<string> GetUnionFromSets(params string[] setIds);
        string GetValue(string key);
        string GetValueFromHash(string hashId, string key);
        List<T> GetValues<T>(List<string> keys);
        List<string> GetValues(List<string> keys);
        List<string> GetValuesFromHash(string hashId, params string[] keys);
        Dictionary<string, string> GetValuesMap(List<string> keys);
        Dictionary<string, T> GetValuesMap<T>(List<string> keys);
        bool HashContainsEntry(string hashId, string key);
        bool HasLuaScript(string sha1Ref);
        long Increment(string key, uint amount);
        double IncrementItemInSortedSet(string setId, string value, double incrementBy);
        double IncrementItemInSortedSet(string setId, string value, long incrementBy);
        long IncrementValue(string key);
        long IncrementValueBy(string key, int count);
        long IncrementValueInHash(string hashId, string key, int incrementBy);
        long IncrementValueInHash(string hashId, string key, long incrementBy);
        void Init();
        void KillRunningLuaScript();
        string LoadLuaScript(string body);
        void MoveBetweenSets(string fromSetId, string toSetId, string item);
       
        string PopAndPushItemBetweenLists(string fromListId, string toListId);
        string PopItemFromList(string listId);
        string PopItemFromSet(string setId);
        string PopItemWithHighestScoreFromSortedSet(string setId);
        string PopItemWithLowestScoreFromSortedSet(string setId);
        void PrependItemToList(string listId, string value);
        void PrependRangeToList(string listId, List<string> values);
        long PublishMessage(string toChannel, string message);
        void PushItemToList(string listId, string value);
        bool Remove(string key);
        void RemoveAll(IEnumerable<string> keys);
        void RemoveAllFromList(string listId);
        void RemoveAllLuaScripts();
        string RemoveEndFromList(string listId);
        bool RemoveEntry(params string[] keys);
        bool RemoveEntryFromHash(string hashId, string key);
        long RemoveItemFromList(string listId, string value);
        long RemoveItemFromList(string listId, string value, int noOfMatches);
        void RemoveItemFromSet(string setId, string item);
        bool RemoveItemFromSortedSet(string setId, string value);
        long RemoveRangeFromSortedSet(string setId, int minRank, int maxRank);
        long RemoveRangeFromSortedSetByScore(string setId, double fromScore, double toScore);
        long RemoveRangeFromSortedSetByScore(string setId, long fromScore, long toScore);
        string RemoveStartFromList(string listId);
        void RenameKey(string fromName, string toName);
        bool Replace<T>(string key, T value);
        bool Replace<T>(string key, T value, DateTime expiresAt);
        bool Replace<T>(string key, T value, TimeSpan expiresIn);
        void RewriteAppendOnlyFileAsync();
        List<string> SearchKeys(string pattern);
        bool Set<T>(string key, T value);
        bool Set<T>(string key, T value, DateTime expiresAt);
        bool Set<T>(string key, T value, TimeSpan expiresIn);
        void SetAll(Dictionary<string, string> map);
        void SetAll<T>(IDictionary<string, T> values);
        void SetAll(IEnumerable<string> keys, IEnumerable<string> values);
        void SetConfig(string configItem, string value);
        bool SetContainsItem(string setId, string item);
        void SetEntry(string key, string value);
        void SetEntry(string key, string value, TimeSpan expireIn);
        void SetEntryIfExists(string key, string value, TimeSpan expireIn);
        bool SetEntryIfNotExists(string key, string value);
        void SetEntryIfNotExists(string key, string value, TimeSpan expireIn);
        bool SetEntryInHash(string hashId, string key, string value);
        bool SetEntryInHashIfNotExists(string hashId, string key, string value);
        void SetItemInList(string listId, int listIndex, string value);
        void SetRangeInHash(string hashId, IEnumerable<KeyValuePair<string, string>> keyValuePairs);
        bool SortedSetContainsItem(string setId, string value);
        T Store<T>(T entity);
        void StoreAll<TEntity>(IEnumerable<TEntity> entities);
        void StoreAsHash<T>(T entity);
        void StoreDifferencesFromSet(string intoSetId, string fromSetId, params string[] withSetIds);
        void StoreIntersectFromSets(string intoSetId, params string[] setIds);
        long StoreIntersectFromSortedSets(string intoSetId, params string[] setIds);
        object StoreObject(object entity);
        void StoreUnionFromSets(string intoSetId, params string[] setIds);
        long StoreUnionFromSortedSets(string intoSetId, params string[] setIds);
        void TrimList(string listId, int keepStartingFrom, int keepEndingAt);
        Dictionary<string, bool> WhichLuaScriptsExists(params string[] sha1Refs);
        void WriteAll<TEntity>(IEnumerable<TEntity> entities);
    }
}