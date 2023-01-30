using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    private float _maxSpeed = 10f;
    private float _attackRange = 40f;
    private float _attackDamage = 10f;
    private float _attackInterval = 3f;
    private int _maxHp = 100;

    public int MAXHp => _maxHp;
    public float MAXSpeed => _maxSpeed;
    public float AttackRange => _attackRange;
    public float AttackDamage => _attackDamage;
    public float AttackInterval => _attackInterval;
}
public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;
    private float _currentSpeed = 0f;
    private int _currentHp = 100;

    private void Start()
    {
        var speed = enemyData.MAXSpeed;
    }
}
